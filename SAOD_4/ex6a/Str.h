#pragma once
#include "_str.h";
using namespace std;


class Str {
	_str* m_pStr;
public:
	Str() { m_pStr = new _str; }		//если не копия, то создаем
	Str(const char* p) {		// новый ресурс
		m_pStr = new _str(p);
	}
	~Str() {
		m_pStr->Release(); 	// Не уничтожаем ресурс!
	}				// Уменьшаем счетчик ссылок!

	int len() const {
		return strlen(m_pStr->m_pszData);
	}
	Str(const Str& s)
	{
		m_pStr = s.m_pStr; 	// ссылаемся на тот же ресурс
		m_pStr->AddRef(); 	// отмечаем, что сослались
	}
	Str& operator = (const Str& s) {
		if (this != &s) {
			s.m_pStr->AddRef(); // Важен порядок?!
			m_pStr->Release();
			m_pStr = s.m_pStr;
		}
		return *this;
	}
	Str& operator += (const Str& s) {
		int length = len() + s.len();
		if (s.len() != 0) {		
			_str* pstrTmp = new _str; 	
			delete[] pstrTmp->m_pszData;

			pstrTmp->m_pszData = new char[length + 1];
			strcpy(pstrTmp->m_pszData, m_pStr->m_pszData);
			strcat(pstrTmp->m_pszData, s.m_pStr->m_pszData);

			m_pStr->Release();
			m_pStr = pstrTmp;
		}
		return *this;
	}
	operator const char* () const {
		
		return m_pStr->m_pszData;
	}

	int rfind(const char* t, int off) const {
		int ln = strlen(t) - 1;
		const char* tt = t + ln;

		int sovpad = 0;
		
		for (char* p1 = m_pStr->m_pszData + off + ln; p1 > m_pStr->m_pszData; p1--) {
			
			if (*tt == *p1) {
				sovpad++;
				tt--;
			}
			else {
				tt = t + ln;
				sovpad = 0;
			}
			if (sovpad == ln + 1) {
				return p1 - m_pStr->m_pszData;
			}
			
		}
		return -1;

	}




};

