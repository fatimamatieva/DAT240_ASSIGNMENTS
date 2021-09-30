﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UiS.Dat240.Lab2;

namespace UiS.Dat240.Lab2.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("UiS.Dat240.Lab2.FoodItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CookTime")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("FoodItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CookTime = 13,
                            Description = "Totam numquam eligendi impedit velit dolore accusamus et labore ex voluptatem sit aliquam distinctio et et.",
                            Name = "Beatae voluptas totam accusantium voluptas.",
                            Price = 90.989999999999995
                        },
                        new
                        {
                            Id = 2,
                            CookTime = 11,
                            Description = "Cumque temporibus ut deleniti voluptatum sint eaque id ut est totam qui quo porro magnam eos soluta distinctio.",
                            Name = "Atque voluptatem sunt tempore quod.",
                            Price = 118.98999999999999
                        },
                        new
                        {
                            Id = 3,
                            CookTime = 17,
                            Description = "Sint aliquam ex voluptatem saepe perspiciatis hic et quo blanditiis harum.",
                            Name = "Cumque quasi rerum in.",
                            Price = 241.99000000000001
                        },
                        new
                        {
                            Id = 4,
                            CookTime = 16,
                            Description = "Corrupti fugiat occaecati fuga rerum repudiandae sit enim ex repellat porro quis ut aliquid mollitia repellendus vel.",
                            Name = "Modi ducimus voluptates ab odio.",
                            Price = 66.989999999999995
                        },
                        new
                        {
                            Id = 5,
                            CookTime = 10,
                            Description = "Saepe et quia repellat autem sit quas eveniet quidem dicta minus minus dolorum voluptatibus non rerum unde quo.",
                            Name = "Accusamus consequatur alias quibusdam incidunt.",
                            Price = 198.99000000000001
                        },
                        new
                        {
                            Id = 6,
                            CookTime = 6,
                            Description = "Dolorem suscipit occaecati consequatur soluta eum est reprehenderit repudiandae sit.",
                            Name = "Velit et odio.",
                            Price = 216.99000000000001
                        },
                        new
                        {
                            Id = 7,
                            CookTime = 20,
                            Description = "Excepturi illo est praesentium qui quo incidunt quaerat nostrum inventore rerum soluta deleniti quaerat assumenda recusandae delectus.",
                            Name = "Quia optio repellendus consequatur.",
                            Price = 187.99000000000001
                        },
                        new
                        {
                            Id = 8,
                            CookTime = 14,
                            Description = "Impedit delectus vel sed consectetur molestias eaque natus ipsa optio qui eum quam.",
                            Name = "Tenetur aliquam consequatur.",
                            Price = 123.98999999999999
                        },
                        new
                        {
                            Id = 9,
                            CookTime = 17,
                            Description = "Sed sunt laboriosam nihil labore perferendis quibusdam repudiandae omnis quaerat quae nemo.",
                            Name = "In nihil ut libero quas.",
                            Price = 200.99000000000001
                        },
                        new
                        {
                            Id = 10,
                            CookTime = 16,
                            Description = "Voluptas rerum repellendus provident eum sint animi architecto dolor excepturi.",
                            Name = "Eligendi et dolor.",
                            Price = 157.99000000000001
                        },
                        new
                        {
                            Id = 11,
                            CookTime = 10,
                            Description = "Assumenda enim voluptatem voluptas consequuntur itaque totam laboriosam fugit et voluptas voluptatum.",
                            Name = "Quo deleniti molestiae consequatur.",
                            Price = 227.99000000000001
                        },
                        new
                        {
                            Id = 12,
                            CookTime = 11,
                            Description = "Et quidem earum et ea tempora perspiciatis impedit totam enim laboriosam occaecati dolores exercitationem excepturi asperiores natus excepturi pariatur veritatis.",
                            Name = "Et dolor deserunt facere ipsa.",
                            Price = 58.990000000000002
                        },
                        new
                        {
                            Id = 13,
                            CookTime = 5,
                            Description = "Expedita rerum tempore assumenda et eos harum vitae ratione est impedit et harum facilis nisi quas a.",
                            Name = "Ut cumque et dolor tenetur.",
                            Price = 128.99000000000001
                        },
                        new
                        {
                            Id = 14,
                            CookTime = 7,
                            Description = "Reiciendis voluptates quas et nihil sint omnis ab deserunt sit vel iure nam facere magnam et debitis voluptates esse.",
                            Name = "Expedita et beatae.",
                            Price = 208.99000000000001
                        },
                        new
                        {
                            Id = 15,
                            CookTime = 20,
                            Description = "Maxime labore sed nihil doloremque eaque aut assumenda temporibus sit ea reiciendis vel incidunt rerum distinctio sit laborum.",
                            Name = "Velit omnis rerum.",
                            Price = 217.99000000000001
                        },
                        new
                        {
                            Id = 16,
                            CookTime = 14,
                            Description = "Nostrum voluptas quo dolores maxime aut aut ipsum sed non rerum maiores.",
                            Name = "Quia dolores fuga quis placeat.",
                            Price = 205.99000000000001
                        },
                        new
                        {
                            Id = 17,
                            CookTime = 13,
                            Description = "Voluptas deleniti consequatur et non nobis necessitatibus sed aut quos suscipit veniam.",
                            Name = "Sapiente et architecto eveniet provident.",
                            Price = 218.99000000000001
                        },
                        new
                        {
                            Id = 18,
                            CookTime = 6,
                            Description = "Ea inventore velit qui dignissimos fuga inventore vel rerum et numquam omnis rem eius sit ducimus quis doloremque optio illum.",
                            Name = "Hic quo laborum.",
                            Price = 115.98999999999999
                        },
                        new
                        {
                            Id = 19,
                            CookTime = 6,
                            Description = "Veritatis saepe aut vitae laudantium non consequuntur consequuntur et facere consequatur dolor accusamus nemo rerum nostrum necessitatibus earum et et.",
                            Name = "Et odio omnis nihil.",
                            Price = 215.99000000000001
                        },
                        new
                        {
                            Id = 20,
                            CookTime = 15,
                            Description = "Reiciendis quis necessitatibus et quia ipsam illo ut magni dicta ut sunt necessitatibus perferendis.",
                            Name = "Et qui quibusdam facilis quia.",
                            Price = 157.99000000000001
                        },
                        new
                        {
                            Id = 21,
                            CookTime = 20,
                            Description = "Dolores nobis quidem aut asperiores dolor dicta earum libero veniam aut nihil blanditiis laudantium voluptatum quaerat.",
                            Name = "Rerum sit eos nisi.",
                            Price = 199.99000000000001
                        },
                        new
                        {
                            Id = 22,
                            CookTime = 13,
                            Description = "Inventore dolor voluptatem fuga pariatur et sit vitae et temporibus sed veniam perferendis quia debitis ratione amet quam aliquam quis.",
                            Name = "Inventore possimus at quia aut.",
                            Price = 87.989999999999995
                        },
                        new
                        {
                            Id = 23,
                            CookTime = 18,
                            Description = "Dolore veniam temporibus facilis commodi distinctio dolor itaque repellat dolorem.",
                            Name = "Sit quaerat sed.",
                            Price = 114.98999999999999
                        },
                        new
                        {
                            Id = 24,
                            CookTime = 15,
                            Description = "Aut minus libero perferendis voluptates similique iusto et est placeat et odit beatae.",
                            Name = "Dolorum fuga accusantium tempore.",
                            Price = 122.98999999999999
                        },
                        new
                        {
                            Id = 25,
                            CookTime = 9,
                            Description = "Dolorum fugiat iure debitis quia accusamus animi animi nam natus provident in voluptates quis totam ex ut autem modi.",
                            Name = "Recusandae quibusdam rerum ratione.",
                            Price = 91.989999999999995
                        },
                        new
                        {
                            Id = 26,
                            CookTime = 18,
                            Description = "Illo est eum eum cupiditate et aliquid eveniet veniam dolores officia.",
                            Name = "Et iusto saepe maxime a.",
                            Price = 190.99000000000001
                        },
                        new
                        {
                            Id = 27,
                            CookTime = 14,
                            Description = "Beatae dolor dolore optio nihil quam itaque unde est ea hic.",
                            Name = "Voluptatem amet delectus nihil.",
                            Price = 248.99000000000001
                        },
                        new
                        {
                            Id = 28,
                            CookTime = 14,
                            Description = "Voluptatum recusandae similique quasi aut repellendus cupiditate autem dolorem hic dolore rem amet in aut doloribus consequatur doloribus ea.",
                            Name = "Et perspiciatis reiciendis minus ratione.",
                            Price = 244.99000000000001
                        },
                        new
                        {
                            Id = 29,
                            CookTime = 20,
                            Description = "Ea molestiae ipsa qui qui fugiat eligendi qui est quia mollitia quidem saepe error est optio nesciunt deleniti.",
                            Name = "Nihil dolores suscipit voluptatem perferendis.",
                            Price = 210.99000000000001
                        },
                        new
                        {
                            Id = 30,
                            CookTime = 10,
                            Description = "Dolor quis deserunt incidunt architecto id hic assumenda id aut eveniet et autem.",
                            Name = "Odio id doloribus.",
                            Price = 180.99000000000001
                        });
                });
#pragma warning restore 612, 618
        }
    }
}