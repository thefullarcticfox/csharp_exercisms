using System;

public struct ComplexNumber
{
    private double _real, _imag;

    public ComplexNumber(double real, double imaginary)
    {
        _real = real;
        _imag = imaginary;
    }

    public double Real()
    {
        return _real;
    }

    public double Imaginary()
    {
        return _imag;
    }

    public ComplexNumber Mul(ComplexNumber other)
    {
        //	(a + i * b) * (c + i * d) = (a * c - b * d) + (b * c + a * d) * i
		double	res_real = this._real * other._real - this._imag * other._imag;
		double	res_imag = this._imag * other._real + this._real * other._imag;
		return new ComplexNumber(res_real, res_imag);
    }

    public ComplexNumber Add(ComplexNumber other) => new ComplexNumber(this._real + other._real, this._imag + other._imag);
    public ComplexNumber Sub(ComplexNumber other) => new ComplexNumber(this._real - other._real, this._imag - other._imag);

    public ComplexNumber Div(ComplexNumber other)
    {
        //	(a + i * b) / (c + i * d) = (a * c + b * d) / (c^2 + d^2) + (b * c - a * d) / (c^2 + d^2) * i
		if (other._real == 0 && other._imag == 0)
			throw new DivideByZeroException("division by zero");

		double	res_real = (this._real * other._real + this._imag * other._imag) /
							(other._real * other._real + other._imag * other._imag);
		double	res_imag = (this._imag * other._real - this._real * other._imag) /
							(other._real * other._real + other._imag * other._imag);
		return new ComplexNumber(res_real, res_imag);
    }

    public double Abs() => Math.Sqrt(_real * _real + _imag * _imag);

    public ComplexNumber Conjugate() => new ComplexNumber(_real, -_imag);
    public ComplexNumber Exp()
    {
        //	e^(a + i * b) = e^a * (cos(b) + i * sin(b))		(Euler's formula)
		double	muitiplier = Math.Pow(Math.E, _real);
		return new ComplexNumber(muitiplier * Math.Cos(_imag), muitiplier * Math.Sin(_imag));
    }
}
