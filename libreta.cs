using System;
using System.IO;

namespace Notas
{
    class Libreta {

        string nombreArchivo = "";

        public Libreta(string nombreArchivo) {
            this.nombreArchivo = nombreArchivo;
        }

        public void AgregarNota() {
            System.Console.WriteLine("AgregarNota");
            System.Console.WriteLine("Escribe tu nota:");
            string nota = Console.ReadLine();

            //Archivos: abrir, (modificar)[, flush, cerrar]
            bool append = true;
            using (var file = new StreamWriter(this.nombreArchivo, append)) {
                file.WriteLine(nota);
            }
            System.Console.WriteLine("Nota agregada");
        }

        public void ConsultarNotas() {
            System.Console.WriteLine("Consultar Notas");
            System.Console.WriteLine("--------------");
            System.Console.WriteLine("Notas");
            System.Console.WriteLine("");
            string[] lineas = File.ReadAllLines(this.nombreArchivo);
            foreach (var linea in lineas)
            {
                System.Console.WriteLine(linea);
            }
            System.Console.WriteLine("--------------");
        }

        public void BorrarNotas() {
            System.Console.WriteLine("Borrar Notas");
            bool append = false;
            using (var file = new StreamWriter(this.nombreArchivo, append)) {
                file.WriteLine("");
            }
            System.Console.WriteLine("Notas borradas");
        }
    }
}