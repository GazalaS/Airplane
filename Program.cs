// See https://aka.ms/new-console-template for more information
using Airplane.Extensions;
using Airplane.Services;
using Microsoft.Extensions.DependencyInjection;

string fileName = @"C:\Input\commands.txt";

var serviceProvider = ServicesExtensions.BuildServiceProvider();

var airplaneService = serviceProvider.GetService<IAirplaneService>();
Console.WriteLine(airplaneService.Navigate(fileName));
Console.ReadLine();