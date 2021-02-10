using ExcecaoPersonalizada.Entities;
using System;
using ExcecaoPersonalizada.Entities.Exceptions;

namespace ExcecaoPersonalizada
{
    class Program
    {
        public static void Main(string[] args)
        {


            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation res = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + res);

                Console.WriteLine("\nEnter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                res.UpdateDates(checkIn, checkOut);
                Console.WriteLine("\nReservation: " + res);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unespected error: " + e.Message);
            }

        }

    }
}

