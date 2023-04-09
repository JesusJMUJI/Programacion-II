using System;

namespace Ej2
{
    internal class Ej2
    {

        public class Persona
        {
            public string DNI { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }

            public Persona(string dni, string nombre, string direccion)
            {
                DNI = dni;
                Nombre = nombre;
                Direccion = direccion;
            }
        }

        public class CuentaBancaria
        {
            public int NumeroCuenta { get; set; }
            public Persona Titular { get; set; }
            public decimal Saldo { get; set; }

            public CuentaBancaria(int numeroCuenta, Persona titular, decimal saldo)
            {
                NumeroCuenta = numeroCuenta;
                Titular = titular;
                Saldo = saldo;
            }
        }

        public class Banco
        {
            public string Direccion { get; set; }
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            private CuentaBancaria[] cuentas = new CuentaBancaria[1000];
            public int cantidadCuentasBancarias;

            public Banco(string direccion, string codigo, string nombre)
            {
                Direccion = direccion;
                Codigo = codigo;
                Nombre = nombre;
            }

            public void AgregarCuenta(CuentaBancaria cuenta)
            {
                if (cantidadCuentasBancarias >= 1000)
                {
                    Console.WriteLine("No pueden haber mas de 100 cuentas");
                }
                else
                {
                    cuentas[cantidadCuentasBancarias] = cuenta;
                    cantidadCuentasBancarias++;
                }
            }

            public int ContarCuentas()
            {
                int totalClientes = 0;

                for (int i = 0; i < cuentas.Length; i++)
                {
                    totalClientes++;
                }
                return totalClientes;
            }

            public decimal Activos()
            {
                decimal totalActivos = 0;
                for (int i = 0; i < cantidadCuentasBancarias; i++)
                {
                    totalActivos += cuentas[i].Saldo;
                }
                return totalActivos;
            }
        }
    }
}
