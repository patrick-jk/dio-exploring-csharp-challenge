using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

var guests = new List<Guest>();

var p1 = new Guest(nome: "Guest 1");
var p2 = new Guest(nome: "Guest 2");

guests.Add(p1);
guests.Add(p2);

var suite = new Suite(suiteType: "Premium", capacity: 1, dailyRatePrice: 100);

var reservation = new Reservation(reservedDays: 10);
reservation.RegisterSuite(suite);
reservation.RegisterGuest(guests);

Console.WriteLine($"Guests: {reservation.GetGuestsQuantity()}");
Console.WriteLine($"Hotal Daily Rate Price: {reservation.CalculateDailyHotelRate()}");