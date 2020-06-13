
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.Nama = "La Ode Muhammad Aldin";
            mhs.Nim = "19.11.2807";
            mhs.Alamat = "jl. prof. Dr Abd Rauf Tarimana";
            mhs.Email = "ode.al@students.amikom.ac.id";
            mhs.CetakInformasi();

            Dosen dosen = new Dosen();
            dosen.Nama = "Kamarudin";
            dosen.Nik = "190302123";
            dosen.NPWP = "11223344234";
            dosen.Alamat = "Jl.Wonosari";
            dosen.Email = "Kamarudin@amikom.ac.id";
            dosen.Nohp = "0813  12334";
            dosen.CetakInformasi();
        }
    }
}