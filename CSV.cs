using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ATM
{
    class CSV
    {
        public static void ReadingCSV(List<int> pincode, List<double> balance2, List<int> accountnumber, int listposition, string strPath)
        {
            using (var filestream = new FileStream(strPath, FileMode.Open, FileAccess.Read))
            {
                using (var streamreader = new StreamReader(filestream))
                {
                    while (!streamreader.EndOfStream)
                    {
                        var line = streamreader.ReadLine();
                        var values = line.Split(';');

                        accountnumber.Add(Convert.ToInt32(values[0]));
                        pincode.Add(Convert.ToInt32(values[1]));
                        balance2.Add(Convert.ToDouble(values[2]));
                    }
                }
            }
        }
        public static void WritingCSV(List<int> pincode, List<double> balance2, List<int> accountnumber, int listposition, string strPath)
        {
            using (var filestream = new FileStream(strPath, FileMode.Open, FileAccess.Write))
            {
                using (var writer = new StreamWriter(filestream))
                {
                    for (int i = 0; i < accountnumber.Count; i++)
                    {
                        var lineout = (Convert.ToString(accountnumber[i]) + ";" + Convert.ToString(pincode[i]) + ";" + (Convert.ToString(balance2[i])));
                        writer.WriteLine(lineout, Encoding.UTF8);
                    }

                }
            }
        }
    }
}
