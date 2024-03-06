
#pragma once


class Str {
	char* m_pszText;
public:
	
	Str() 	
	{
		m_pszText = new char[1] {0};
	}
	Str(const char* p)
	{
		if (p) {
			m_pszText = new char[strlen(p) + 1];
			strcpy(m_pszText, p);
		}
		else
			m_pszText = new char[1] {0};
	}
	
	Str(const Str& s) //Константная ссылка на объект
	{
		m_pszText = new char[strlen(s.m_pszText) + 1];
		strcpy(m_pszText,s.m_pszText);
	}
	inline const Str& operator = (const Str& s) //Константная ссылка на объект
	{
		if (&s == this) return *this;
		delete[] m_pszText;	
		m_pszText = new char[strlen(s.m_pszText) + 1];
		strcpy(m_pszText, s.m_pszText);
		return *this;
	}
	inline Str& operator +=(const char* sz) {
		if (sz) {
			
			char n = strlen(m_pszText);
			char* m1_pszText = new char[n + strlen(sz) + 1];
			char* p1 = m1_pszText;
			for (const char* p = m_pszText; *p; p++, p1++) {
				*p1 = *p;
				
			}
			for (const char* p = sz; *p; p++, p1++) {
				*p1 = *p;
			}
			*p1 = '\0';

			delete[] m_pszText;
			
			m_pszText = new char[n + strlen(sz) + 1];
			strcpy(m_pszText, m1_pszText);
			/*for (char* p = m_pszText, *p2 = m1_pszText; *(p2); p++, p2++) {
				*p = *p2;
			}*/
			
			//m_pszText = m1_pszText;

			delete[] m1_pszText;
			
			return *this;

		}
	}
	inline Str operator +(const char* sz) const {
		
		if (sz) {
			char n = strlen(m_pszText);
			char* m1_pszText = new char[n + strlen(sz) + 1];
			char* p1 = m1_pszText;
			
			for (const char* p = m_pszText; *p; p++, p1++) {
				*p1 = *p;
			}
			for (const char* p = sz; *p; p++, p1++) {
				*p1 = *p;
			}
			*p1 = '\0';

			Str m =  m1_pszText;
			delete[] m1_pszText;
			return m;

		}
		else {
			Str s = m_pszText;
			return s;
	}
	}
	inline operator const char* () const { return m_pszText; }
	

	~Str() { delete[]m_pszText; }
};
inline void Test(Str s) {}

