using ServidorODATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServidorODATA
{
    public class EjercitoDataSource
    {
        private static EjercitoDataSource instance = null;
        public static EjercitoDataSource Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EjercitoDataSource();
                }
                return instance;
            }
        }
        public List<Ejercito> Ejercitosos { get; set; }
        private EjercitoDataSource()
        {
            this.Reset();
            this.Initialize();
        }
        public void Reset()
        {
            this.Ejercitosos = new List<Ejercito>();
        }
        public void Initialize()
        {
            this.Ejercitosos.AddRange(new List<Ejercito>
            {
                new Ejercito()
                {
                    Id=1,
                    Name="Aire",
                    FechNac=new DateTime(2008, 3, 1),
                    FuerzaCombate =6,
                    Ubicacion="Logroño"
                },
                new Ejercito()
                {
                    Id=2,
                    Name="Tierra",
                    FechNac=new DateTime(2000, 1, 1),
                    FuerzaCombate=2,
                    Ubicacion="Madrid"
                },
                new Ejercito()
                {
                   Id=3,
                   Name="Mar",
                   FechNac=new DateTime(2005, 2, 2),
                   FuerzaCombate=7,
                   Ubicacion="Bilbao"
                },
                new Ejercito()
                {
                    Id=4,
                    Name="Espacio",
                    FechNac=new DateTime(2011, 9, 2),
                    FuerzaCombate=9,
                    Ubicacion="Valencia"
                },
                new Ejercito()
                {
                   Id=5,
                   Name="Plasma",
                   FechNac=new DateTime(2021, 8, 12),
                   FuerzaCombate=1,
                   Ubicacion="Barcelona"
                },
                new Ejercito()
                {
                   Id=6,
                   Name="Luz",
                   FechNac=new DateTime(2015, 3, 5),
                   FuerzaCombate=13,
                   Ubicacion="Sevilla"
                },
                new Ejercito()
                {
                   Id=7,
                   Name="Petróleo",
                   FechNac=new DateTime(2017, 8, 6),
                   FuerzaCombate=4,
                   Ubicacion="Burgos"
                },
                new Ejercito()
                {
                   Id=8,
                   Name="Nébula",
                   FechNac=new DateTime(2015, 9, 9),
                   FuerzaCombate=7,
                   Ubicacion="Toledo"
                },
                new Ejercito()
                {
                   Id=9,
                   Name="Vacío",
                   FechNac=new DateTime(2022, 2, 5),
                   FuerzaCombate=11,
                   Ubicacion="Turruncún"
                }
            });
        }
    }
}