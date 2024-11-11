using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using USchedule.Domain.Entities;

namespace USchedule.Repository.Utility.SeedConfiguration
{
    public class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
    {
        public void Configure(EntityTypeBuilder<Faculty> builder)
        {
            builder.HasData(
                new Faculty
                {
                    Name = "Біологічний факультет",
                    Address = "вул. Грушевського, 4, м. Львів 79005, Україна"
                },
                new Faculty
                {
                    Name = "Географічний факультет",
                    Address = "вул. Дорошенка, 41, м. Львів, 79000, Україна"
                },
                new Faculty
                {
                    Name = "Геологічний факультет",
                    Address = "вул. Грушевського, 4, м. Львів 79005, Україна"
                },
                new Faculty
                {
                    Name = "Економічний факультет",
                    Address = "проспект Свободи, 18, м. Львів, 79008, Україна"
                },
                new Faculty
                {
                    Name = "Факультет електроніки та комп’ютерних технологій",
                    Address = "вул. Драгоманова, 50, м. Львів, 79005, Україна"
                },
                new Faculty
                {
                    Name = "Факультет журналістики",
                    Address = "вул. Генерала Чупринки, 49, м. Львів, 79044, Україна"
                },
                new Faculty
                {
                    Name = "Факультет іноземних мов",
                    Address = "вул. Університетська 1/415, м. Львів, 79000, Україна"
                },
                new Faculty
                {
                    Name = "Історичний факультет",
                    Address = "вул. Університетська, 1, м. Львів, 79000, Україна"
                },
                new Faculty
                {
                    Name = "Факультет культури і мистецтв",
                    Address = "вул. Валова,18, м. Львів, 79008, Україна"
                },
                new Faculty
                {
                    Name = "Механіко-математичний факультет",
                    Address = "вул. Університетська, 1 м. Львів, 79000, Україна"
                },
                new Faculty
                {
                    Name = "Факультет міжнародних відносин",
                    Address = "вул. Січових Стрільців, 19, м. Львів, 79000, Україна"
                },
                new Faculty
                {
                    Name = "Факультет педагогічної освіти",
                    Address = "вул. Туган-Барановського, 7, м. Львів, 79000, Україна"
                },
                new Faculty
                {
                    Name = "Факультет прикладної математики та інформатики",
                    Address = "вул. Університетська 1, м. Львів, 79000, Україна"
                },
                new Faculty
                {
                    Name = "Факультет управління фінансами та бізнесу",
                    Address = "вул. Коперника, 3, м. Львів, 79000, Україна"
                },
                new Faculty
                {
                    Name = "Фізичний факультет",
                    Address = "вул. Кирила і Мефодія, 8, м. Львів, 79005, Україна"
                },
                new Faculty
                {
                    Name = "Філологічний факультет",
                    Address = "вул. Університетська, 1, кімната 232, м. Львів, 79000, Україна"
                },
                new Faculty
                {
                    Name = "Філософський факультет",
                    Address = "вул. Університетська, 1, м. Львів, 79001, Україна"
                },
                new Faculty
                {
                    Name = "Хімічний факультет",
                    Address = "вул. Кирила і Мефодія, 6, м. Львів, 79005, Україна"
                },
                new Faculty
                {
                    Name = "Юридичний факультет",
                    Address = "вул. Січових Стрільців, 14, м. Львів, 79000, Україна"
                }
            );
        }
    }
}
