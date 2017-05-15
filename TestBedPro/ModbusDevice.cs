using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modbus.Device;
using System.IO.Ports;
using System.Globalization;

namespace TestBedPro
{
    public class ModbusDevice
    {

        RadnaTacka _radnaTacka;

        public ModbusDevice()
        {
            _radnaTacka = new RadnaTacka();
        }

        public RadnaTacka RadnaTacka
        {
            get
            {
                return _radnaTacka;
            }
        }

        public bool FetchData(SerialPort serialPort, int timeout)
        {
            if (serialPort.IsOpen)
            {
                using (var master = ModbusSerialMaster.CreateRtu(serialPort))
                {
                    master.Transport.ReadTimeout = timeout;

                    ushort[] HH = master.ReadInputRegisters(2, 550, 1);
                    ushort[] QQ = master.ReadInputRegisters(2, 551, 1);
                    // if(slave2test.Count()>0)
                    _radnaTacka._h = HH[0];
                    _radnaTacka._q = QQ[0];

                    ushort[] bratee = master.ReadInputRegisters(1, 28, 12);
                    ushort[] snaga = master.ReadInputRegisters(1, 0, 12);
                    ushort[] cosfi = master.ReadInputRegisters(1, 10, 2);

                    string[] riRString = bratee.Select(x => x.ToString("X")).ToArray();
                    string[] pString = snaga.Select(x => x.ToString("X")).ToArray();
                    short output = short.Parse(riRString[0], NumberStyles.HexNumber);

                    _radnaTacka._uL1 = Convert.ToDouble(riRString[0]) * Math.Pow(10, (short)bratee[1]);
                    _radnaTacka._uL2 = Convert.ToDouble(riRString[2]) * Math.Pow(10, (short)bratee[3]);
                    _radnaTacka._uL3 = Convert.ToDouble(riRString[4]) * Math.Pow(10, (short)bratee[5]);
                    _radnaTacka._iL1 = Convert.ToDouble(riRString[6]) * Math.Pow(10, (short)bratee[7]);
                    _radnaTacka._iL2 = Convert.ToDouble(riRString[8]) * Math.Pow(10, (short)bratee[9]);
                    _radnaTacka._iL3 = Convert.ToDouble(riRString[10]) * Math.Pow(10, (short)bratee[11]);

                    _radnaTacka._u3p = Convert.ToDouble(pString[0]) * Math.Pow(10, (short)snaga[1]);
                    _radnaTacka._i3p = Convert.ToDouble(pString[2]) * Math.Pow(10, (short)snaga[3]);
                    _radnaTacka._p3p = Convert.ToDouble(pString[4]) * Math.Pow(10, (short)snaga[5]);
                    _radnaTacka._cosphi3p = Convert.ToDouble(pString[10]) * Math.Pow(10, (short)snaga[11]);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
