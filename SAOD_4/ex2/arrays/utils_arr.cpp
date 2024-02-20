void rotate(int a[], int n, bool clockwise = false) {

    if (!clockwise) {
        int x = a[0];
        for (int* i = a; i - a < n; i++) {
            *i = *i + 1;
        }
        a[n - 1] = x;
    }
    else {
        int x = a[n - 1];
        for (int* i = a + 4; i - a != 0; i--) {
            *i = *i - 1;
        }
        a[0] = x;
    }
}
