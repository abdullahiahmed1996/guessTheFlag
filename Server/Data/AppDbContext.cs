﻿
using GuessTheFlag.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace GuessTheFlag.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<CountryModel> Countries { get; set; }
        public DbSet<FlagModel> Flags { get; set; }
        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryModel>().HasData(
                new CountryModel { Id = 1, Name = "Afghanistan" },
                new CountryModel { Id = 2, Name = "Albania" },
                new CountryModel { Id = 3, Name = "Algeria" },
                new CountryModel { Id = 4, Name = "Andorra" },
                new CountryModel { Id = 5, Name = "Angola" },
                new CountryModel { Id = 6, Name = "Antigua and Barbuda" },
                new CountryModel { Id = 7, Name = "Argentina" },
                new CountryModel { Id = 8, Name = "Armenia" },
                new CountryModel { Id = 9, Name = "Australia" },
                new CountryModel { Id = 10, Name = "Austria" },
                new CountryModel { Id = 11, Name = "Azerbaijan" },
                new CountryModel { Id = 12, Name = "Bahamas" },
                new CountryModel { Id = 13, Name = "Bahrain" },
                new CountryModel { Id = 14, Name = "Bangladesh" },
                new CountryModel { Id = 15, Name = "Barbados" },
                new CountryModel { Id = 16, Name = "Belarus" },
                new CountryModel { Id = 17, Name = "Belgium" },
                new CountryModel { Id = 18, Name = "Belize" },
                new CountryModel { Id = 19, Name = "Benin" },
                new CountryModel { Id = 20, Name = "Bhutan" },
                new CountryModel { Id = 21, Name = "Bolivia" },
                new CountryModel { Id = 22, Name = "Bosnia and Herzegovina" },
                new CountryModel { Id = 23, Name = "Botswana" },
                new CountryModel { Id = 24, Name = "Brazil" },
                new CountryModel { Id = 25, Name = "Brunei" },
                new CountryModel { Id = 26, Name = "Bulgaria" },
                new CountryModel { Id = 27, Name = "Burkina Faso" },
                new CountryModel { Id = 28, Name = "Burundi" },
                new CountryModel { Id = 29, Name = "Cabo Verde" },
                new CountryModel { Id = 30, Name = "Cambodia" },
                new CountryModel { Id = 31, Name = "Cameroon" },
                new CountryModel { Id = 32, Name = "Canada" },
                new CountryModel { Id = 33, Name = "Central African Republic" },
                new CountryModel { Id = 34, Name = "Chad" },
                new CountryModel { Id = 35, Name = "Chile" },
                new CountryModel { Id = 36, Name = "China" },
                new CountryModel { Id = 37, Name = "Colombia" },
                new CountryModel { Id = 38, Name = "Comoros" },
                new CountryModel { Id = 39, Name = "Congo (Brazzaville)" },
                new CountryModel { Id = 40, Name = "Congo (Kinshasa)" },
                new CountryModel { Id = 41, Name = "Costa Rica" },
                new CountryModel { Id = 42, Name = "Croatia" },
                new CountryModel { Id = 43, Name = "Cuba" },
                new CountryModel { Id = 44, Name = "Cyprus" },
                new CountryModel { Id = 45, Name = "Czechia" },
                new CountryModel { Id = 46, Name = "Denmark" },
                new CountryModel { Id = 47, Name = "Djibouti" },
                new CountryModel { Id = 48, Name = "Dominica" },
                new CountryModel { Id = 49, Name = "Dominican Republic" },
                new CountryModel { Id = 50, Name = "East Timor" },
                new CountryModel { Id = 51, Name = "Ecuador" },
                new CountryModel { Id = 52, Name = "Egypt" },
                new CountryModel { Id = 53, Name = "El Salvador" },
                new CountryModel { Id = 54, Name = "Equatorial Guinea" },
                new CountryModel { Id = 55, Name = "Eritrea" },
                new CountryModel { Id = 56, Name = "Estonia" },
                new CountryModel { Id = 57, Name = "Eswatini" },
                new CountryModel { Id = 58, Name = "Ethiopia" },
                new CountryModel { Id = 59, Name = "Fiji" },
                new CountryModel { Id = 60, Name = "Finland" },
                new CountryModel { Id = 61, Name = "France" },
                new CountryModel { Id = 62, Name = "Gabon" },
                new CountryModel { Id = 63, Name = "Gambia" },
                new CountryModel { Id = 64, Name = "Georgia" },
                new CountryModel { Id = 65, Name = "Germany" },
                new CountryModel { Id = 66, Name = "Ghana" },
                new CountryModel { Id = 67, Name = "Greece" },
                new CountryModel { Id = 68, Name = "Grenada" },
                new CountryModel { Id = 69, Name = "Guatemala" },
                new CountryModel { Id = 70, Name = "Guinea" },
                new CountryModel { Id = 71, Name = "Guinea-Bissau" },
                new CountryModel { Id = 72, Name = "Guyana" },
                new CountryModel { Id = 73, Name = "Haiti" },
                new CountryModel { Id = 74, Name = "Honduras" },
                new CountryModel { Id = 75, Name = "Hungary" },
                new CountryModel { Id = 76, Name = "Iceland" },
                new CountryModel { Id = 77, Name = "India" },
                new CountryModel { Id = 78, Name = "Indonesia" },
                new CountryModel { Id = 79, Name = "Iran" },
                new CountryModel { Id = 80, Name = "Iraq" },
                new CountryModel { Id = 81, Name = "Ireland" },
                new CountryModel { Id = 82, Name = "Israel" },
                new CountryModel { Id = 83, Name = "Italy" },
                new CountryModel { Id = 84, Name = "Ivory Coast" },
                new CountryModel { Id = 85, Name = "Jamaica" },
                new CountryModel { Id = 86, Name = "Japan" },
                new CountryModel { Id = 87, Name = "Jordan" },
                new CountryModel { Id = 88, Name = "Kazakhstan" },
                new CountryModel { Id = 89, Name = "Kenya" },
                new CountryModel { Id = 90, Name = "Kiribati" },
                new CountryModel { Id = 91, Name = "Korea, North" },
                new CountryModel { Id = 92, Name = "Korea, South" },
                new CountryModel { Id = 93, Name = "Kosovo" },
                new CountryModel { Id = 94, Name = "Kuwait" },
                new CountryModel { Id = 95, Name = "Kyrgyzstan" },
                new CountryModel { Id = 96, Name = "Laos" },
                new CountryModel { Id = 97, Name = "Latvia" },
                new CountryModel { Id = 98, Name = "Lebanon" },
                new CountryModel { Id = 99, Name = "Lesotho" },
                new CountryModel { Id = 100, Name = "Liberia" },
                new CountryModel { Id = 101, Name = "Libya" },
                new CountryModel { Id = 102, Name = "Liechtenstein" },
                new CountryModel { Id = 103, Name = "Lithuania" },
                new CountryModel { Id = 104, Name = "Luxembourg" },
                new CountryModel { Id = 105, Name = "Macedonia" },
                new CountryModel { Id = 106, Name = "Madagascar" },
                new CountryModel { Id = 107, Name = "Malawi" },
                new CountryModel { Id = 108, Name = "Malaysia" },
                new CountryModel { Id = 109, Name = "Maldives" },
                new CountryModel { Id = 110, Name = "Mali" },
                new CountryModel { Id = 111, Name = "Malta" },
                new CountryModel { Id = 112, Name = "Marshall Islands" },
                new CountryModel { Id = 113, Name = "Mauritania" },
                new CountryModel { Id = 114, Name = "Mauritius" },
                new CountryModel { Id = 115, Name = "Mexico" },
                new CountryModel { Id = 116, Name = "Micronesia" },
                new CountryModel { Id = 117, Name = "Moldova" },
                new CountryModel { Id = 118, Name = "Monaco" },
                new CountryModel { Id = 119, Name = "Mongolia" },
                new CountryModel { Id = 120, Name = "Montenegro" },
                new CountryModel { Id = 121, Name = "Morocco" },
                new CountryModel { Id = 122, Name = "Mozambique" },
                new CountryModel { Id = 123, Name = "Myanmar" },
                new CountryModel { Id = 124, Name = "Namibia" },
                new CountryModel { Id = 125, Name = "Nauru" },
                new CountryModel { Id = 126, Name = "Nepal" },
                new CountryModel { Id = 127, Name = "Netherlands" },
                new CountryModel { Id = 128, Name = "New Zealand" },
                new CountryModel { Id = 129, Name = "Nicaragua" },
                new CountryModel { Id = 130, Name = "Niger" },
                new CountryModel { Id = 131, Name = "Nigeria" },
                new CountryModel { Id = 132, Name = "North Macedonia" },
                new CountryModel { Id = 133, Name = "Norway" },
                new CountryModel { Id = 134, Name = "Oman" },
                new CountryModel { Id = 135, Name = "Pakistan" },
                new CountryModel { Id = 136, Name = "Palau" },
                new CountryModel { Id = 137, Name = "Palestine" },
                new CountryModel { Id = 138, Name = "Panama" },
                new CountryModel { Id = 139, Name = "Papua New Guinea" },
                new CountryModel { Id = 140, Name = "Paraguay" },
                new CountryModel { Id = 141, Name = "Peru" },
                new CountryModel { Id = 142, Name = "Philippines" },
                new CountryModel { Id = 143, Name = "Poland" },
                new CountryModel { Id = 144, Name = "Portugal" },
                new CountryModel { Id = 145, Name = "Qatar" },
                new CountryModel { Id = 146, Name = "Romania" },
                new CountryModel { Id = 147, Name = "Russia" },
                new CountryModel { Id = 148, Name = "Rwanda" },
                new CountryModel { Id = 149, Name = "Saint Kitts and Nevis" },
                new CountryModel { Id = 150, Name = "Saint Lucia" },
                new CountryModel { Id = 151, Name = "Saint Vincent and the Grenadines" },
                new CountryModel { Id = 152, Name = "Samoa" },
                new CountryModel { Id = 153, Name = "San Marino" },
                new CountryModel { Id = 154, Name = "Sao Tome and Principe" },
                new CountryModel { Id = 155, Name = "Saudi Arabia" },
                new CountryModel { Id = 156, Name = "Senegal" },
                new CountryModel { Id = 157, Name = "Serbia" },
                new CountryModel { Id = 158, Name = "Seychelles" },
                new CountryModel { Id = 159, Name = "Sierra Leone" },
                new CountryModel { Id = 160, Name = "Singapore" },
                new CountryModel { Id = 161, Name = "Slovakia" },
                new CountryModel { Id = 162, Name = "Slovenia" },
                new CountryModel { Id = 163, Name = "Solomon Islands" },
                new CountryModel { Id = 164, Name = "Somalia" },
                new CountryModel { Id = 165, Name = "South Africa" },
                new CountryModel { Id = 166, Name = "South Sudan" },
                new CountryModel { Id = 167, Name = "Spain" },
                new CountryModel { Id = 168, Name = "Sri Lanka" },
                new CountryModel { Id = 169, Name = "Sudan" },
                new CountryModel { Id = 170, Name = "Suriname" },
                new CountryModel { Id = 171, Name = "Sweden" },
                new CountryModel { Id = 172, Name = "Switzerland" },
                new CountryModel { Id = 173, Name = "Syria" },
                new CountryModel { Id = 174, Name = "Taiwan" },
                new CountryModel { Id = 175, Name = "Tajikistan" },
                new CountryModel { Id = 176, Name = "Tanzania" },
                new CountryModel { Id = 177, Name = "Thailand" },
                new CountryModel { Id = 178, Name = "Togo" },
                new CountryModel { Id = 179, Name = "Tonga" },
                new CountryModel { Id = 180, Name = "Trinidad and Tobago" },
                new CountryModel { Id = 181, Name = "Tunisia" },
                new CountryModel { Id = 182, Name = "Turkey" },
                new CountryModel { Id = 183, Name = "Turkmenistan" },
                new CountryModel { Id = 184, Name = "Tuvalu" },
                new CountryModel { Id = 185, Name = "Uganda" },
                new CountryModel { Id = 186, Name = "Ukraine" },
                new CountryModel { Id = 187, Name = "United Arab Emirates" },
                new CountryModel { Id = 188, Name = "United Kingdom" },
                new CountryModel { Id = 189, Name = "United States" },
                new CountryModel { Id = 190, Name = "Uruguay" },
                new CountryModel { Id = 191, Name = "Uzbekistan" },
                new CountryModel { Id = 192, Name = "Vanuatu" },
                new CountryModel { Id = 193, Name = "Vatican City" },
                new CountryModel { Id = 194, Name = "Venezuela" },
                new CountryModel { Id = 195, Name = "Vietnam" },
                new CountryModel { Id = 196, Name = "Yemen" },
                new CountryModel { Id = 197, Name = "Zambia" },
                new CountryModel { Id = 198, Name = "Zimbabwe" }
                );

            modelBuilder.Entity<FlagModel>().HasData(
               new FlagModel { Id = 1, ImgUrl = "Afghanistan.gif", CountryId = 1 },
               new FlagModel { Id = 2, ImgUrl = "Albania.gif", CountryId = 2 },
               new FlagModel { Id = 3, ImgUrl = "Algeria.gif", CountryId = 3 },
               new FlagModel { Id = 4, ImgUrl = "Andorra.gif", CountryId = 4 },
               new FlagModel { Id = 5, ImgUrl = "Angola.gif", CountryId = 5 },
               new FlagModel { Id = 6, ImgUrl = "Antigua_and_Barbuda.gif", CountryId = 6 },
               new FlagModel { Id = 7, ImgUrl = "Argentina.gif", CountryId = 7 },
               new FlagModel { Id = 8, ImgUrl = "Armenia.gif", CountryId = 8 },
               new FlagModel { Id = 9, ImgUrl = "Australia.gif", CountryId = 9 },
               new FlagModel { Id = 10, ImgUrl = "Austria.gif", CountryId = 10 },
               new FlagModel { Id = 11, ImgUrl = "Azerbaijan.gif", CountryId = 11 },
               new FlagModel { Id = 12, ImgUrl = "Bahamas.gif", CountryId = 12 },
               new FlagModel { Id = 13, ImgUrl = "Bahrain.gif", CountryId = 13 },
               new FlagModel { Id = 14, ImgUrl = "Bangladesh.gif", CountryId = 14 },
               new FlagModel { Id = 15, ImgUrl = "Barbados.gif", CountryId = 15 },
               new FlagModel { Id = 16, ImgUrl = "Belarus.gif", CountryId = 16 },
               new FlagModel { Id = 17, ImgUrl = "Belgium.gif", CountryId = 17 },
               new FlagModel { Id = 18, ImgUrl = "Belize.gif", CountryId = 18 },
               new FlagModel { Id = 19, ImgUrl = "Benin.gif", CountryId = 19 },
               new FlagModel { Id = 20, ImgUrl = "Bhutan.gif", CountryId = 20 },
               new FlagModel { Id = 21, ImgUrl = "Bolivia.gif", CountryId = 21 },
               new FlagModel { Id = 22, ImgUrl = "Bosnia_and_Herzegovina.gif", CountryId = 22 },
               new FlagModel { Id = 23, ImgUrl = "Botswana.gif", CountryId = 23 },
               new FlagModel { Id = 24, ImgUrl = "Brazil.gif", CountryId = 24 },
                    new FlagModel { Id = 25, ImgUrl = "Brunei.gif", CountryId = 25 },
                    new FlagModel { Id = 26, ImgUrl = "Bulgaria.gif", CountryId = 26 },
                    new FlagModel { Id = 27, ImgUrl = "Burkina_Faso.gif", CountryId = 27 },
                    new FlagModel { Id = 28, ImgUrl = "Burundi.gif", CountryId = 28 },
                    new FlagModel { Id = 29, ImgUrl = "Cabo_Verde.gif", CountryId = 29 },
                    new FlagModel { Id = 30, ImgUrl = "Cambodia.gif", CountryId = 30 },
                    new FlagModel { Id = 31, ImgUrl = "Cameroon.gif", CountryId = 31 },
                    new FlagModel { Id = 32, ImgUrl = "Canada.gif", CountryId = 32 },
                    new FlagModel { Id = 33, ImgUrl = "Central_African_Republic.gif", CountryId = 33 },
                    new FlagModel { Id = 34, ImgUrl = "Chad.gif", CountryId = 34 },
                    new FlagModel { Id = 35, ImgUrl = "Chile.gif", CountryId = 35 },
                    new FlagModel { Id = 36, ImgUrl = "China.gif", CountryId = 36 },
                    new FlagModel { Id = 37, ImgUrl = "Colombia.gif", CountryId = 37 },
                    new FlagModel { Id = 38, ImgUrl = "Comoros.gif", CountryId = 38 },
                    new FlagModel { Id = 39, ImgUrl = "Congo_(Brazzaville).gif", CountryId = 39 },
                    new FlagModel { Id = 40, ImgUrl = "Congo_(Kinshasa).gif", CountryId = 40 },
                    new FlagModel { Id = 41, ImgUrl = "Costa_Rica.gif", CountryId = 41 },
                    new FlagModel { Id = 42, ImgUrl = "Croatia.gif", CountryId = 42 },
                    new FlagModel { Id = 43, ImgUrl = "Cuba.gif", CountryId = 43 },
                    new FlagModel { Id = 44, ImgUrl = "Cyprus.gif", CountryId = 44 },
                    new FlagModel { Id = 45, ImgUrl = "Czechia.gif", CountryId = 45 },
                    new FlagModel { Id = 46, ImgUrl = "Denmark.gif", CountryId = 46 },
                    new FlagModel { Id = 47, ImgUrl = "Djibouti.gif", CountryId = 47 },
                    new FlagModel { Id = 48, ImgUrl = "Dominica.gif", CountryId = 48 },
                    new FlagModel { Id = 49, ImgUrl = "Dominican_Republic.gif", CountryId = 49 },
                    new FlagModel { Id = 50, ImgUrl = "East_Timor.gif", CountryId = 50 },
                    new FlagModel { Id = 51, ImgUrl = "Ecuador.gif", CountryId = 51 },
                    new FlagModel { Id = 52, ImgUrl = "Egypt.gif", CountryId = 52 },
                    new FlagModel { Id = 53, ImgUrl = "El_Salvador.gif", CountryId = 53 },
                    new FlagModel { Id = 54, ImgUrl = "Equatorial_Guinea.gif", CountryId = 54 },
                    new FlagModel { Id = 55, ImgUrl = "Eritrea.gif", CountryId = 55 },
                    new FlagModel { Id = 56, ImgUrl = "Estonia.gif", CountryId = 56 },
                    new FlagModel { Id = 57, ImgUrl = "Eswatini.gif", CountryId = 57 },
                    new FlagModel { Id = 58, ImgUrl = "Ethiopia.gif", CountryId = 58 },
                    new FlagModel { Id = 59, ImgUrl = "Fiji.gif", CountryId = 59 },
                    new FlagModel { Id = 60, ImgUrl = "Finland.gif", CountryId = 60 },
                    new FlagModel { Id = 61, ImgUrl = "France.gif", CountryId = 61 },
                    new FlagModel { Id = 62, ImgUrl = "Gabon.gif", CountryId = 62 },
                    new FlagModel { Id = 63, ImgUrl = "Gambia.gif", CountryId = 63 },
                    new FlagModel { Id = 64, ImgUrl = "Georgia.gif", CountryId = 64 },
                    new FlagModel { Id = 65, ImgUrl = "Germany.gif", CountryId = 65 },
                    new FlagModel { Id = 66, ImgUrl = "Ghana.gif", CountryId = 66 },
                    new FlagModel { Id = 67, ImgUrl = "Greece.gif", CountryId = 67 },
                    new FlagModel { Id = 68, ImgUrl = "Grenada.gif", CountryId = 68 },
                    new FlagModel { Id = 69, ImgUrl = "Guatemala.gif", CountryId = 69 },
                    new FlagModel { Id = 70, ImgUrl = "Guinea.gif", CountryId = 70 },
                    new FlagModel { Id = 71, ImgUrl = "Guinea-Bissau.gif", CountryId = 71 },
                    new FlagModel { Id = 72, ImgUrl = "Guyana.gif", CountryId = 72 },
                    new FlagModel { Id = 73, ImgUrl = "Haiti.gif", CountryId = 73 },
                    new FlagModel { Id = 74, ImgUrl = "Honduras.gif", CountryId = 74 },
                    new FlagModel { Id = 75, ImgUrl = "Hungary.gif", CountryId = 75 },
                    new FlagModel { Id = 76, ImgUrl = "Iceland.gif", CountryId = 76 },
                    new FlagModel { Id = 77, ImgUrl = "India.gif", CountryId = 77 },
                    new FlagModel { Id = 78, ImgUrl = "Indonesia.gif", CountryId = 78 },
                    new FlagModel { Id = 79, ImgUrl = "Iran.gif", CountryId = 79 },
                    new FlagModel { Id = 80, ImgUrl = "Iraq.gif", CountryId = 80 },
                    new FlagModel { Id = 81, ImgUrl = "Ireland.gif", CountryId = 81 },
                    new FlagModel { Id = 82, ImgUrl = "Israel.gif", CountryId = 82 },
                    new FlagModel { Id = 83, ImgUrl = "Italy.gif", CountryId = 83 },
                    new FlagModel { Id = 84, ImgUrl = "Ivory_Coast.gif", CountryId = 84 },
                    new FlagModel { Id = 85, ImgUrl = "Jamaica.gif", CountryId = 85 },
                    new FlagModel { Id = 86, ImgUrl = "Japan.gif", CountryId = 86 },
                    new FlagModel { Id = 87, ImgUrl = "Jordan.gif", CountryId = 87 },
                    new FlagModel { Id = 88, ImgUrl = "Kazakhstan.gif", CountryId = 88 },
                    new FlagModel { Id = 89, ImgUrl = "Kenya.gif", CountryId = 89 },
                    new FlagModel { Id = 90, ImgUrl = "Kiribati.gif", CountryId = 90 },
                    new FlagModel { Id = 91, ImgUrl = "Korea,_North.gif", CountryId = 91 },
                    new FlagModel { Id = 92, ImgUrl = "Korea,_South.gif", CountryId = 92 },
                    new FlagModel { Id = 93, ImgUrl = "Kosovo.gif", CountryId = 93 },
                    new FlagModel { Id = 94, ImgUrl = "Kuwait.gif", CountryId = 94 },
                    new FlagModel { Id = 95, ImgUrl = "Kyrgyzstan.gif", CountryId = 95 },
                    new FlagModel { Id = 96, ImgUrl = "Laos.gif", CountryId = 96 },
                    new FlagModel { Id = 97, ImgUrl = "Latvia.gif", CountryId = 97 },
                    new FlagModel { Id = 98, ImgUrl = "Lebanon.gif", CountryId = 98 },
                    new FlagModel { Id = 99, ImgUrl = "Lesotho.gif", CountryId = 99 },
                    new FlagModel { Id = 100, ImgUrl = "Liberia.gif", CountryId = 100 },
                    new FlagModel { Id = 101, ImgUrl = "Libya.gif", CountryId = 101 },
                    new FlagModel { Id = 102, ImgUrl = "Liechtenstein.gif", CountryId = 102 },
                    new FlagModel { Id = 103, ImgUrl = "Lithuania.gif", CountryId = 103 },
                    new FlagModel { Id = 104, ImgUrl = "Luxembourg.gif", CountryId = 104 },
                    new FlagModel { Id = 105, ImgUrl = "Macedonia.gif", CountryId = 105 },
                    new FlagModel { Id = 106, ImgUrl = "Madagascar.gif", CountryId = 106 },
                    new FlagModel { Id = 107, ImgUrl = "Malawi.gif", CountryId = 107 },
                    new FlagModel { Id = 108, ImgUrl = "Malaysia.gif", CountryId = 108 },
                    new FlagModel { Id = 109, ImgUrl = "Maldives.gif", CountryId = 109 },
                    new FlagModel { Id = 110, ImgUrl = "Mali.gif", CountryId = 110 },
                    new FlagModel { Id = 111, ImgUrl = "Malta.gif", CountryId = 111 },
                    new FlagModel { Id = 112, ImgUrl = "Marshall_Islands.gif", CountryId = 112 },
                    new FlagModel { Id = 113, ImgUrl = "Mauritania.gif", CountryId = 113 },
                    new FlagModel { Id = 114, ImgUrl = "Mauritius.gif", CountryId = 114 },
                    new FlagModel { Id = 115, ImgUrl = "Mexico.gif", CountryId = 115 },
                    new FlagModel { Id = 116, ImgUrl = "Micronesia.gif", CountryId = 116 },
                    new FlagModel { Id = 117, ImgUrl = "Moldova.gif", CountryId = 117 },
                    new FlagModel { Id = 118, ImgUrl = "Monaco.gif", CountryId = 118 },
                    new FlagModel { Id = 119, ImgUrl = "Mongolia.gif", CountryId = 119 },
                    new FlagModel { Id = 120, ImgUrl = "Montenegro.gif", CountryId = 120 },
                    new FlagModel { Id = 121, ImgUrl = "Morocco.gif", CountryId = 121 },
                    new FlagModel { Id = 122, ImgUrl = "Mozambique.gif", CountryId = 122 },
                    new FlagModel { Id = 123, ImgUrl = "Myanmar.gif", CountryId = 123 },
                    new FlagModel { Id = 124, ImgUrl = "Namibia.gif", CountryId = 124 },
                    new FlagModel { Id = 125, ImgUrl = "Nauru.gif", CountryId = 125 },
                    new FlagModel { Id = 126, ImgUrl = "Nepal.gif", CountryId = 126 },
                    new FlagModel { Id = 127, ImgUrl = "Netherlands.gif", CountryId = 127 },
                    new FlagModel { Id = 128, ImgUrl = "New_Zealand.gif", CountryId = 128 },
                    new FlagModel { Id = 129, ImgUrl = "Nicaragua.gif", CountryId = 129 },
                    new FlagModel { Id = 130, ImgUrl = "Niger.gif", CountryId = 130 },
                    new FlagModel { Id = 131, ImgUrl = "Nigeria.gif", CountryId = 131 },
                    new FlagModel { Id = 132, ImgUrl = "North_Macedonia.gif", CountryId = 132 },
                    new FlagModel { Id = 133, ImgUrl = "Norway.gif", CountryId = 133 },
                    new FlagModel { Id = 134, ImgUrl = "Oman.gif", CountryId = 134 },
                    new FlagModel { Id = 135, ImgUrl = "Pakistan.gif", CountryId = 135 },
                    new FlagModel { Id = 136, ImgUrl = "Palau.gif", CountryId = 136 },
                    new FlagModel { Id = 137, ImgUrl = "Palestine.gif", CountryId = 137 },
                    new FlagModel { Id = 138, ImgUrl = "Panama.gif", CountryId = 138 },
                    new FlagModel { Id = 139, ImgUrl = "Papua_New_Guinea.gif", CountryId = 139 },
                    new FlagModel { Id = 140, ImgUrl = "Paraguay.gif", CountryId = 140 },
                    new FlagModel { Id = 141, ImgUrl = "Peru.gif", CountryId = 141 },
                    new FlagModel { Id = 142, ImgUrl = "Philippines.gif", CountryId = 142 },
                    new FlagModel { Id = 143, ImgUrl = "Poland.gif", CountryId = 143 },
                    new FlagModel { Id = 144, ImgUrl = "Portugal.gif", CountryId = 144 },
                    new FlagModel { Id = 145, ImgUrl = "Qatar.gif", CountryId = 145 },
                    new FlagModel { Id = 146, ImgUrl = "Romania.gif", CountryId = 146 },
                    new FlagModel { Id = 147, ImgUrl = "Russia.gif", CountryId = 147 },
                    new FlagModel { Id = 148, ImgUrl = "Rwanda.gif", CountryId = 148 },
                    new FlagModel { Id = 149, ImgUrl = "Saint_Kitts_and_Nevis.gif", CountryId = 149 },
                    new FlagModel { Id = 150, ImgUrl = "Saint_Lucia.gif", CountryId = 150 },
                    new FlagModel { Id = 151, ImgUrl = "Saint_Vincent_and_the_Grenadines.gif", CountryId = 151 },
                    new FlagModel { Id = 152, ImgUrl = "Samoa.gif", CountryId = 152 },
                    new FlagModel { Id = 153, ImgUrl = "San_Marino.gif", CountryId = 153 },
                    new FlagModel { Id = 154, ImgUrl = "Sao_Tome_and_Principe.gif", CountryId = 154 },
                    new FlagModel { Id = 155, ImgUrl = "Saudi_Arabia.gif", CountryId = 155 },
                    new FlagModel { Id = 156, ImgUrl = "Senegal.gif", CountryId = 156 },
                    new FlagModel { Id = 157, ImgUrl = "Serbia.gif", CountryId = 157 },
                    new FlagModel { Id = 158, ImgUrl = "Seychelles.gif", CountryId = 158 },
                    new FlagModel { Id = 159, ImgUrl = "Sierra_Leone.gif", CountryId = 159 },
                    new FlagModel { Id = 160, ImgUrl = "Singapore.gif", CountryId = 160 },
                    new FlagModel { Id = 161, ImgUrl = "Slovakia.gif", CountryId = 161 },
                    new FlagModel { Id = 162, ImgUrl = "Slovenia.gif", CountryId = 162 },
                    new FlagModel { Id = 163, ImgUrl = "Solomon_Islands.gif", CountryId = 163 },
                    new FlagModel { Id = 164, ImgUrl = "Somalia.gif", CountryId = 164 },
                    new FlagModel { Id = 165, ImgUrl = "South_Africa.gif", CountryId = 165 },
                    new FlagModel { Id = 166, ImgUrl = "South_Sudan.gif", CountryId = 166 },
                    new FlagModel { Id = 167, ImgUrl = "Spain.gif", CountryId = 167 },
                    new FlagModel { Id = 168, ImgUrl = "Sri_Lanka.gif", CountryId = 168 },
                    new FlagModel { Id = 169, ImgUrl = "Sudan.gif", CountryId = 169 },
                    new FlagModel { Id = 170, ImgUrl = "Suriname.gif", CountryId = 170 },
                    new FlagModel { Id = 171, ImgUrl = "Sweden.gif", CountryId = 171 },
                    new FlagModel { Id = 172, ImgUrl = "Switzerland.gif", CountryId = 172 },
                    new FlagModel { Id = 173, ImgUrl = "Syria.gif", CountryId = 173 },
                    new FlagModel { Id = 174, ImgUrl = "Taiwan.gif", CountryId = 174 },
                    new FlagModel { Id = 175, ImgUrl = "Tajikistan.gif", CountryId = 175 },
                    new FlagModel { Id = 176, ImgUrl = "Tanzania.gif", CountryId = 176 },
                    new FlagModel { Id = 177, ImgUrl = "Thailand.gif", CountryId = 177 },
                    new FlagModel { Id = 178, ImgUrl = "Togo.gif", CountryId = 178 },
                    new FlagModel { Id = 179, ImgUrl = "Tonga.gif", CountryId = 179 },
                    new FlagModel { Id = 180, ImgUrl = "Trinidad_and_Tobago.gif", CountryId = 180 },
                    new FlagModel { Id = 181, ImgUrl = "Tunisia.gif", CountryId = 181 },
                    new FlagModel { Id = 182, ImgUrl = "Turkey.gif", CountryId = 182 },
                    new FlagModel { Id = 183, ImgUrl = "Turkmenistan.gif", CountryId = 183 },
                    new FlagModel { Id = 184, ImgUrl = "Tuvalu.gif", CountryId = 184 },
                    new FlagModel { Id = 185, ImgUrl = "Uganda.gif", CountryId = 185 },
                    new FlagModel { Id = 186, ImgUrl = "Ukraine.gif", CountryId = 186 },
                    new FlagModel { Id = 187, ImgUrl = "United_Arab_Emirates.gif", CountryId = 187 },
                    new FlagModel { Id = 188, ImgUrl = "United_Kingdom.gif", CountryId = 188 },
                    new FlagModel { Id = 189, ImgUrl = "United_States.gif", CountryId = 189 },
                    new FlagModel { Id = 190, ImgUrl = "Uruguay.gif", CountryId = 190 },
                    new FlagModel { Id = 191, ImgUrl = "Uzbekistan.gif", CountryId = 191 },
                    new FlagModel { Id = 192, ImgUrl = "Vanuatu.gif", CountryId = 192 },
                    new FlagModel { Id = 193, ImgUrl = "Vatican_City.gif", CountryId = 193 },
                    new FlagModel { Id = 194, ImgUrl = "Venezuela.gif", CountryId = 194 },
                    new FlagModel { Id = 195, ImgUrl = "Vietnam.gif", CountryId = 195 },
                    new FlagModel { Id = 196, ImgUrl = "Yemen.gif", CountryId = 196 },
                    new FlagModel { Id = 197, ImgUrl = "Zambia.gif", CountryId = 197 },
                    new FlagModel { Id = 198, ImgUrl = "Zimbabwe.gif", CountryId = 198 }

                    );
        }
    }
}
