#include <algorithm>
#include <chrono>
#include <thread>
#include <iostream>
#include <random>
#include <vector>
#include <limits>
#include <unordered_map>
#include <numeric>
#include <semaphore>

typedef unsigned long long int bigint;

bool is_prime(bigint n)
{
    if (n <= 1)
        return false;
    for (bigint i = 2; i <= n / 2; i++)
        if (n % i == 0)
            return false;
    return true;
}

size_t single(const std::vector<bigint>& v)
{
    return std::count_if(v.begin(), v.end(), [](const auto &el)
    {
        return is_prime(el);
    });
}


size_t block_way(const std::vector<bigint>& v, size_t n_threads)
{
    std::vector<size_t> results(n_threads);
    auto lambda = [&v, &results](size_t a, size_t b, size_t thread_id)
    {
        auto sum = std::count_if(v.begin() + a, v.begin() + b, [](const auto &el)
        {
            return is_prime(el);
        });
        results[thread_id] = sum;
    };

    std::vector<std::thread> threads(n_threads);
    int part_size = v.size() / n_threads, a = 0, b = 0;
    for(int thread_id = 0; thread_id != n_threads; thread_id++, a = b)
    {
        b = (thread_id == n_threads - 1) ? v.size() : a + part_size;
        threads[thread_id] = std::thread(lambda, a, b, thread_id);
    }

    for(auto& t : threads)
        t.join();

    return std::accumulate(results.begin(), results.end(), 0);
}

void process_range(const std::vector<bigint>& v, std::binary_semaphore& sem, size_t& index, size_t& prime_count)
{
    while (true)
    {
        size_t i;
        {
            sem.acquire(); // Захват семафора для защиты доступа к индексу
            if (index >= v.size())
            {
                sem.release();
                return;
            }
            i = index++;
            sem.release(); // Освобождение семафора после доступа к индексу
        }

        if (is_prime(v[i]))
        {
            sem.acquire(); // Захват семафора для защиты доступа к счетчику простых чисел
            prime_count++;
            sem.release(); // Освобождение семафора после обновления счетчика
        }
    }
}

size_t semaphore_way(const std::vector<bigint>& v, size_t n_threads)
{
    std::binary_semaphore sem(1); // Двоичный семафор для синхронизации доступа
    size_t index = 0;
    size_t prime_count = 0;

    std::vector<std::thread> threads;
    for (size_t i = 0; i < n_threads; ++i)
    {
        threads.emplace_back(process_range, std::cref(v), std::ref(sem), std::ref(index), std::ref(prime_count));
    }

    for (auto& t : threads)
        t.join();

    return prime_count;
}

int main()
{
    // список, заполненный случайными натуральными числами
    std::vector<bigint> v(1240);
    std::mt19937_64 gen;
    gen.seed(1);
    std::uniform_int_distribution<bigint> dp(1, bigint(std::numeric_limits<int>::max()));
    for(auto & item : v)
        item = dp(gen);

    // однопоточная версия поиска простых чисел
    auto t1 = std::chrono::high_resolution_clock::now();
    auto nsingle = single(v);
    auto t2 = std::chrono::high_resolution_clock::now();
    auto single_time = std::chrono::duration_cast<std::chrono::milliseconds>(t2 - t1).count();
    std::cout << 1 << '\t' << single_time << '\t' << single_time << '\t' << single_time << std::endl;

    // i - число потоков
    for(size_t i = 2; i <= 8; i += 1)
    {
        t1 = std::chrono::high_resolution_clock::now();
        auto nblock = block_way(v, i);
        t2 = std::chrono::high_resolution_clock::now();
        auto block_time = std::chrono::duration_cast<std::chrono::milliseconds>(t2 - t1).count();

        t1 = std::chrono::high_resolution_clock::now();
        auto nmutex = semaphore_way(v, i);
        t2 = std::chrono::high_resolution_clock::now();
        auto mutex_time = std::chrono::duration_cast<std::chrono::milliseconds>(t2 - t1).count();

        std::cout << i << '\t' << single_time << '\t' << block_time << '\t' << mutex_time << '\t' << nsingle << '\t' << nblock << '\t' << nmutex << std::endl;
    }
}