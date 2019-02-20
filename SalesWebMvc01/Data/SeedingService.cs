using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc01.Models;
using SalesWebMvc01.Models.Enums;

namespace SalesWebMvc01.Data


{   // cria-se a classe seedingService
    public class SeedingService
    {
        private SalesWebMvc01Context _contex; // cria-se uma variável que receber esse contex

        public SeedingService(SalesWebMvc01Context context)
        {
            // depois passa o parametro recebido para o contex agual ou local
            _contex = context; 
        }

        // Operação reponsável por popular a base de dados

        public void Seed()
        {
            if(_contex.Departaments.Any() || _contex.Seller.Any() || _contex.SalesRecord.Any())
            {
                return; // O banco de dados já foi poulado
            }

            // Instanciando e salvando no banco de dados

            Departaments d1 = new Departaments(1, "Comunicação");
            Departaments d2 = new Departaments(2, "Governo");
            Departaments d3 = new Departaments(3, "Compras");
            Departaments d4 = new Departaments(4, "Licitação");


            Seller s1 = new Seller(1, "Adilson Dias", "adilaon@bol.com.br", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Lauro Dias", "l@bol.com.br", new DateTime(1998, 4, 21), 10100.0, d2);
            Seller s3 = new Seller(3, "Mirtes Dias", "m@bol.com.br", new DateTime(1997, 5, 21), 10200.0, d3);
            Seller s4 = new Seller(4, "Fabiana Dias", "f@bol.com.br", new DateTime(1999, 6, 21), 10100.0, d4);
            Seller s5 = new Seller(5, "Lucilene Dias", "l@bol.com.br", new DateTime(2000, 8, 21), 11000.0, d1);
            Seller s6 = new Seller(6, "Junia Dias", "j@bol.com.br", new DateTime(2001, 3, 21), 12000.0, d2);
            Seller s7 = new Seller(7, "Lilian Dias", "ll@bol.com.br", new DateTime(1988, 9, 21), 13000.0, d3);


            SalesRecord sr1 = new SalesRecord (1, new DateTime(2018,09,25), 1300.0, SalesStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2018, 09, 26), 2200.0, SalesStatus.Canceled, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2018, 09, 25), 2300.0, SalesStatus.Peding, s3);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2018, 09, 25), 2400.0, SalesStatus.Billed, s4);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2018, 09, 27), 100.0, SalesStatus.Billed, s5);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2018, 09, 29), 200.0, SalesStatus.Canceled, s6);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2018, 09, 22), 400.0, SalesStatus.Peding, s7);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2018, 09, 12), 4100.0, SalesStatus.Billed, s1);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2018, 09, 11), 1100.0, SalesStatus.Billed, s1);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2018, 09, 20), 1500.0, SalesStatus.Canceled, s2);
            SalesRecord sr11 = new SalesRecord(11, new DateTime(2018, 09, 21), 700.0, SalesStatus.Billed, s1);
            SalesRecord sr12 = new SalesRecord(12, new DateTime(2018, 09, 19), 2300.0, SalesStatus.Billed, s3);
            SalesRecord sr13 = new SalesRecord(13, new DateTime(2018, 09, 29), 1100.0, SalesStatus.Billed, s1);
            SalesRecord sr14 = new SalesRecord(14, new DateTime(2018, 09, 25), 2400.0, SalesStatus.Billed, s4);
            SalesRecord sr15 = new SalesRecord(15, new DateTime(2018, 09, 22), 2300.0, SalesStatus.Billed, s4);
            SalesRecord sr16 = new SalesRecord(16, new DateTime(2018, 09, 24), 4500.0, SalesStatus.Billed, s1);
            SalesRecord sr17 = new SalesRecord(17, new DateTime(2018, 09, 23), 1100.0, SalesStatus.Billed, s3);
            SalesRecord sr18 = new SalesRecord(18, new DateTime(2018, 09, 15), 1300.0, SalesStatus.Canceled, s5);
            SalesRecord sr19 = new SalesRecord(19, new DateTime(2018, 09, 16), 200.0, SalesStatus.Billed, s1);
            SalesRecord sr20 = new SalesRecord(20, new DateTime(2018, 09, 17), 300.0, SalesStatus.Peding, s2);
            SalesRecord sr21 = new SalesRecord(21, new DateTime(2018, 09, 18), 800.0, SalesStatus.Billed, s7);
            SalesRecord sr22 = new SalesRecord(22, new DateTime(2018, 09, 18), 900.0, SalesStatus.Billed, s7);
            SalesRecord sr23 = new SalesRecord(23, new DateTime(2018, 09, 18), 900.0, SalesStatus.Billed, s7);
            SalesRecord sr24 = new SalesRecord(24, new DateTime(2018, 09, 20), 10500.0, SalesStatus.Billed, s7);
            SalesRecord sr25 = new SalesRecord(25, new DateTime(2018, 09, 17), 1000.0, SalesStatus.Peding, s1);
            SalesRecord sr26 = new SalesRecord(26, new DateTime(2018, 09, 09), 10100.0, SalesStatus.Billed, s1);
            SalesRecord sr27 = new SalesRecord(27, new DateTime(2018, 09, 09), 11100.0, SalesStatus.Billed, s6);
            SalesRecord sr28 = new SalesRecord(28, new DateTime(2018, 09, 10), 13100.0, SalesStatus.Billed, s6);
            SalesRecord sr29 = new SalesRecord(29, new DateTime(2018, 09, 25), 14100.0, SalesStatus.Billed, s1);
            SalesRecord sr30 = new SalesRecord(30, new DateTime(2018, 09, 23), 16100.0, SalesStatus.Billed, s5);
            SalesRecord sr32 = new SalesRecord(31, new DateTime(2018, 09, 25), 11100.0, SalesStatus.Peding, s5);
            SalesRecord sr33 = new SalesRecord(32, new DateTime(2018, 09, 23), 1100.0, SalesStatus.Billed, s3);
            SalesRecord sr34 = new SalesRecord(33, new DateTime(2018, 09, 25), 9100.0, SalesStatus.Billed, s3);
            SalesRecord sr35 = new SalesRecord(34, new DateTime(2018, 09, 21), 10100.0, SalesStatus.Canceled, s3);
            SalesRecord sr36 = new SalesRecord(35, new DateTime(2018, 09, 25), 10100.0, SalesStatus.Billed, s2);

            _contex.Departaments.AddRange(d1, d2, d3, d4);

            _contex.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7);

            _contex.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10, sr1, sr12, sr13, sr14, sr15, sr16, sr17, sr18,
                sr19, sr20, sr21, sr22, sr23, sr24, sr25, sr26, sr27, sr28, sr29, sr30, sr32, sr33, sr34, sr36
                );

            _contex.SaveChanges();

        }
           
        

    }
}
