using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using ZaferTurizm.DataAccess.SeedData;
using ZaferTurizm.Domain;

namespace ZaferTurizm.DataAccess.Configurations
{
    internal class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable(nameof(City));
            builder.HasKey(city => city.Id);
            builder.Property(city => city.Name).IsRequired().HasColumnType("varchar(50)");

            builder.HasData(
                CityData.Data01_Adana,
CityData.Data02_Adiyaman,
CityData.Data03_Afyonkarahisar,
CityData.Data04_Ağri,
CityData.Data05_Amasya,
CityData.Data06_Ankara,
CityData.Data07_Antalya,
CityData.Data08_Artvin,
CityData.Data09_Aydin,
CityData.Data10_Balikesir,
CityData.Data11_Bilecik,
CityData.Data12_Bingol,
CityData.Data13_Bitlis,
CityData.Data14_Bolu,
CityData.Data15_Burdur,
CityData.Data16_Bursa,
CityData.Data17_Canakkale,
CityData.Data18_Cankiri,
CityData.Data19_Corum,
CityData.Data20_Denizli,
CityData.Data21_Diyarbakir,
CityData.Data22_Edirne,
CityData.Data23_Elazig,
CityData.Data24_Erzincan,
CityData.Data25_Erzurum,
CityData.Data26_Eskisehir,
CityData.Data27_Gaziantep,
CityData.Data28_Giresun,
CityData.Data29_Gümüşhane,
CityData.Data30_Hakkari,
CityData.Data31_Hatay,
CityData.Data32_Isparta,
CityData.Data33_Mersin,
CityData.Data34_İstanbul,
CityData.Data35_İzmir,
CityData.Data36_Kars,
CityData.Data37_Kastamonu,
CityData.Data38_Kayseri,
CityData.Data39_Kirklareli,
CityData.Data40_Kırşehir,
CityData.Data41_Kocaeli,
CityData.Data42_Konya,
CityData.Data43_Kütahya,
CityData.Data44_Malatya,
CityData.Data45_Manisa,
CityData.Data46_Kahramanmaraş,
CityData.Data47_Mardin,
CityData.Data48_Muğla,
CityData.Data49_Muş,
CityData.Data50_Nevşehir,
CityData.Data51_Niğde,
CityData.Data52_Ordu,
CityData.Data53_Rize,
CityData.Data54_Sakarya,
CityData.Data55_Samsun,
CityData.Data56_Siirt,
CityData.Data57_Sinop,
CityData.Data58_Sivas,
CityData.Data59_Tekirdağ,
CityData.Data60_Tokat,
CityData.Data61_Trabzon,
CityData.Data62_Tunceli,
CityData.Data63_Şanliurfa,
CityData.Data64_Uşak,
CityData.Data65_Van,
CityData.Data66_Yozgat,
CityData.Data67_Zonguldak,
CityData.Data68_Aksaray,
CityData.Data69_Bayburt,
CityData.Data70_Karaman,
CityData.Data71_Kirikkale,
CityData.Data72_Batman,
CityData.Data73_Şirnak,
CityData.Data74_Bartin,
CityData.Data75_Ardahan,
CityData.Data76_Iğdir,
CityData.Data77_Yalova,
CityData.Data78_Karabük,
CityData.Data79_Kilis,
CityData.Data80_Osmaniye,
CityData.Data81_Düzce
                );
        }
    }
}
