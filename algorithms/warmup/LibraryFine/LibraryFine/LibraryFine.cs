using System;

namespace LibraryFine
{
    class LibraryFine
    {
        static void Main(string[] args)
        {
            int fine = 0;
            const int indexDay = 0;
            const int indexMonth = 1;
            const int indexYear = 2;

            var dateReturnActual = (Console.ReadLine() + "").ToString().Split();
            var dateReturnExpected = (Console.ReadLine() + "").ToString().Split();

            if (Convert.ToInt32(dateReturnActual[indexYear]) > Convert.ToInt32(dateReturnExpected[indexYear]))
            {
                fine = 10000;
            }
            else if (dateReturnActual[indexYear].Equals(dateReturnExpected[indexYear]))
            {
                if (Convert.ToInt32(dateReturnActual[indexMonth]) > Convert.ToInt32(dateReturnExpected[indexMonth]))
                {
                    fine = (Convert.ToInt32(dateReturnActual[indexMonth]) - Convert.ToInt32(dateReturnExpected[indexMonth])) * 500;
                }
                else if (dateReturnActual[indexMonth].Equals(dateReturnExpected[indexMonth]))
                {
                    if (Convert.ToInt32(dateReturnActual[indexDay]) > Convert.ToInt32(dateReturnExpected[indexDay]))
                    {
                        fine = (Convert.ToInt32(dateReturnActual[indexDay]) - Convert.ToInt32(dateReturnExpected[indexDay])) * 15;
                    }
                }
            }


            Console.WriteLine(fine);
            Console.ReadLine();
        }

        //        var dateReturnActual = Convert.ToDateTime((Console.ReadLine() + ""));
        //var dateReturnExpected = Convert.ToDateTime((Console.ReadLine() + ""));
        //int fine = 0;

        //if (dateReturnActual <= dateReturnExpected)
        //{
        //    fine = 0;
        //}
        //else if (dateReturnActual.Month.Equals(dateReturnExpected.Month) &&
        //            dateReturnActual.Year.Equals(dateReturnExpected.Year))
        //{
        //    var dayDiff = (dateReturnActual - dateReturnExpected).TotalDays;
        //    fine = (int)dayDiff * 15;
        //}
        //else if (!dateReturnActual.Month.Equals(dateReturnExpected.Month) &&
        //            dateReturnActual.Year.Equals(dateReturnExpected.Year))
        //{
        //    var monthDiff = dateReturnActual.Month - dateReturnExpected.Month;
        //    fine = monthDiff * 500;
        //}
        //else
        //{
        //    fine = 1000;
        //}

        //Console.WriteLine(fine);

    }
}
