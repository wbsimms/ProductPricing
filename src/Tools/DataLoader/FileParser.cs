using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductPricing.DataAccess.Models;

namespace DataLoader
{
    [TestClass]
    public class FileParser
    {
        [TestMethod]
        public void ParseData()
        {
            string s =
                "FlyersAndBrochures	11\" X 17\" 100lb Dull Book Flyers with Satin AQ coating	500	4:0	5-7 Business Days	$225.00	UPS Ground -  $17.06	UPS 3 Day Select -  $37.65	UPS 2nd Day Air -  $47.45	UPS Next Day Air Saver -  $53.93	UPS 2nd Day Air A.M. -  $53.95	UPS Next Day Air -  $56.25	UPS Next Day Air Early A.M. -  $225.31	FLAT - No Folding	Accordion Fold (add $8.00 per job)	Half-Fold (add $8.00 per job)	Roll Fold (add $8.00 per job)	Tri-Fold / Letter Fold (add $8.00 per job)	Z-Fold (add $8.00 per job)	Gatefold (add $12.00 per job)	Double Parallel Fold (add $15.00 per job)	French Fold (add $15.00 per job)	Half-Fold and then Tri-Fold (add $15.00 per job)	Double Gatefold (add $40.00 per job)";
            //foreach (string s in File.ReadLines(""))
            //{
                Product p = new Product(); 
                string[] bits = s.Split('\t');
                if (bits[0] == "FlyersAndBrochures") p.ProductTypeId = 4;
                p.Description = bits[1];
                int lenghtOfSize = p.Description.LastIndexOf('"');
                p.Size = p.Description.Substring(0,lenghtOfSize+1);
                p.Description = p.Description.Remove(0, lenghtOfSize+1).Trim();
                int lengthOfStock = p.Description.IndexOf(' ', 0);
                p.Stock = p.Description.Substring(0, lengthOfStock+1);
                p.Description = p.Description.Remove(0, lengthOfStock+1).TrimStart();
                p.Runsize = Convert.ToInt32(bits[2]);
                p.Color = bits[3];
                p.TurnAroundTime = bits[4];
                p.Price = bits[5];
                for (int i = 6; i <= bits.Length;i++)
                {
                    HandleNextBit(bits[i],p);
                }
            //}

           
        }

        public void HandleNextBit(string bit, Product p)
        {
            if (bit.StartsWith("UPS"))
            {
                p.ShippingOptions += bit+" ";
            }
            else
            {
                p.OtherOptions += bit+" ";
            }
        }
    }
}
