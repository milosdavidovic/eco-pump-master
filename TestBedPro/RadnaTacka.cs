using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBedPro
{
    public class RadnaTacka
    {
        public double _q { get; set; }
        public double _h { get; set; }
        public double _uL1 { get; set; }
        public double _uL2 { get; set; }
        public double _uL3 { get; set; }
        public double _iL1 { get; set; }
        public double _iL2 { get; set; }
        public double _iL3 { get; set; }
        public double _u3p { get; set; }
        public double _i3p { get; set; }
        public double _p3p { get; set; }
        public double _cosphi3p { get; set; }
        public double _cosphiL1 { get; set; }
        public double _cosphiL2 { get; set; }
        public double _cosphiL3 { get; set; }
        public string _referenca { get; set; }
        public string _korisnik { get; set; }
        public string _napomena { get; set; }

        public RadnaTacka()
        {
            _q = 0;
            _h = 0;
            _uL1 = 0;
            _uL2 = 0;
            _uL3 = 0;
            _iL1 = 0;
            _iL2 = 0;
            _iL3 = 0;
            _u3p = 0;
            _i3p = 0;
            _p3p = 0;
            _cosphi3p = 0;
            _cosphiL1 = 0;
            _cosphiL2 = 0;
            _cosphiL3 = 0;
            _referenca = "";
            _korisnik = "";
            _napomena = "";
        }
        public RadnaTacka(RadnaTacka r)
        {
            _q = r._q;
            _h = r._h;
            _uL1 = r._uL1;
            _uL2 = r._uL2;
            _uL3 = r._uL3;
            _iL1 = r._iL1;
            _iL2 = r._iL2;
            _iL3 = r._iL3;
            _u3p = r._u3p;
            _i3p = r._i3p;
            _p3p = r._p3p;
            _cosphi3p = r._cosphi3p;
            _cosphiL1 = r._cosphiL1;
            _cosphiL2 = r._cosphiL2;
            _cosphiL3 = r._cosphiL3;
            _referenca = r._referenca;
            _korisnik = r._korisnik;
            _napomena = r._napomena;
        }

    }
}
