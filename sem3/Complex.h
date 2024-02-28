#pragma once
#include <cmath>

class Complex
{
public:
	double Re, Im;
	
	Complex(double re = 0, double im = 0) {
		Re = re;
		Im = im;
	}

	Complex operator +(const Complex& c)const
	{
		return Complex(Re + c.Re, Im + c.Im);
	}
	Complex operator -(const Complex& c)const
	{
		return Complex(Re - c.Re, Im - c.Im);
	}
	Complex operator *(const Complex& c)const
	{
		//a c + a d i + b c i + b d i 2.
		double n_re, n_im;
		n_re = Re * c.Re - Im * c.Im;
		n_im = Re * c.Im + c.Re * Im;
		return Complex(n_re, n_im);
	}
	Complex operator /(const Complex& c)const
	{
		double n_re, n_im;
		n_re = (Re * c.Re) / (c.Re * c.Re + c.Im * c.Im);
		n_im = (Im * c.Re - Re * c.Im) / (c.Re * c.Re + c.Im * c.Im);
		return Complex(n_re, n_im);
	}
	Complex Conjugate() {
		return Complex(Re, Im * (-1));
	}
	double Mod() {
		return sqrt(Re * Re + Im * Im);
	}
	double Arg() {
		if (this->Mod() == 0) return 0;
		if (Re > 0) return atan(Im / Re);
		if (Re < 0) {
			if (Im >= 0) return acos(-1) + atan(Im / Re);
			else return acos(-1) - atan(Im / Re);
		}
		if (Im >= 0) return acos(0);
		else return -acos(0);
	
		
	}
};
inline std::ostream& operator << (std::ostream& o, const Complex& c)
{
	return o << '(' << c.Re << ", " << c.Im << ')';
}



