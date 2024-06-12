using Coffee.Models;
using Microsoft.EntityFrameworkCore;
namespace Coffee.Data
{
 public static class ModelBuilderExtensions
 {
 public static ModelBuilder Seed(this ModelBuilder modelBuilder){
 modelBuilder.Entity<Product>().HasData(
new Product
 {
 Id = 1,
Name = "Black Coffee",
 Description = "Black Coffee dapat membantu meningkatkan daya ingat.",
 Price = 40.000m,
ImageName = "1.jpg"
 },
new Product
 {
 Id = 2,
Name = "Coffee Latte",
Description = "Latte sangat baik dalam mengelola diabetes tipe-2.",
 Price = 50.000m,
ImageName = "2.jpg"
 },
 new Product
 {
 Id = 3,
 Name = "Coffee Cappucino",
Description = "cappucino dapat membantu mengatasi kolesterol dan mencegah beberapa masalah yang berhubungan dengan jantung. ",
 Price = 60.000m,
ImageName = "3.jpeg"
 },
 new Product
 {
 Id = 4,
Name = "Americano Coffee",
Description = "Coffee yang dapat membantu melawan depresi",
Price = 60.000m,
ImageName = "4.jpg"
 },
 new Product
 {
 Id = 5,
Name = "Espresso Coffee",
Description = "Coffee yand dapat Mengurangi risiko stroke",
 Price = 54.000m,
ImageName = "5.jpg"
 },
 new Product
 {
 Id = 6,
Name = "Mocha Coffee",
Description = " Coffee yang dapat merontokan lemak secara alami.",
 Price = 75.000m,
ImageName = "6.jpg"
 }
 );
 return modelBuilder;
 }
 }
}