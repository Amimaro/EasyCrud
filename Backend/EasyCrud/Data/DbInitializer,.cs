using System;
using System.Linq;
using EasyCrud.Models;
using EasyCrud.Contexts;

namespace EasyCrud.Data
{
public static class DbInitializer
{
public static void Initialize(ProgrammerContext context)
{
        context.Database.EnsureCreated();

        // Look for any students.
        if (context.Programmer.Any())
        {
                return;   // DB has been seeded
        }

        var availability = new Availability[] {
                new Availability {
                        Op1=true, Op2=false, Op3=false, Op4=false, Op5=false
                },
                new Availability {
                        Op1=false, Op2=true, Op3=false, Op4=false, Op5=false
                },
                new Availability {
                        Op1=false, Op2=false, Op3=true, Op4=false, Op5=false
                }
        };
        var bankinfo = new BankInfo[] {
                new BankInfo {
                        Name="Teste 1",
                        Cpf="987654321-1",
                        Bank="TestBank1",
                        Agency="123-1",
                        AccType=0,
                        AccNumber="321-1"
                },
                new BankInfo {
                        Name="Teste 2",
                        Cpf="987654321-2",
                        Bank="TestBank2",
                        Agency="123-2",
                        AccType=0,
                        AccNumber="321-2"
                },
                new BankInfo {
                        Name="Teste 3",
                        Cpf="987654321-3",
                        Bank="TestBank3",
                        Agency="123-3",
                        AccType=1,
                        AccNumber="321-3"
                }
        };
        var besttime = new BestTime[] {
                new BestTime {
                        Op1=true, Op2=false, Op3=false, Op4=false, Op5=false
                },
                new BestTime {
                        Op1=false, Op2=true, Op3=false, Op4=false, Op5=false
                },
                new BestTime {
                        Op1=false, Op2=false, Op3=true, Op4=false, Op5=false
                }
        };
        var knoledge = new Knoledge[] {
                new Knoledge {
                        Ionic="1",
                        Android="1",
                        Ios="1",
                        Html="1",
                        Css="1",
                        Bootstrap="1",
                        Jquery="1",
                        Angular="1",
                        Java="1",
                        Aspnet="1",
                        C="1",
                        Cpp="1",
                        Cake="1",
                        Django="1",
                        Majento="1",
                        Php="1",
                        Wordpress="1",
                        Python="1",
                        Ruby="1",
                        Sqls="1",
                        Mysql="1",
                        Salesforce="1",
                        Photoshop="1",
                        Illustrator="1",
                        Seo="1",
                        Other="1"
                },
                new Knoledge {
                        Ionic="2",
                        Android="2",
                        Ios="2",
                        Html="2",
                        Css="2",
                        Bootstrap="2",
                        Jquery="2",
                        Angular="2",
                        Java="2",
                        Aspnet="2",
                        C="2",
                        Cpp="2",
                        Cake="2",
                        Django="2",
                        Majento="2",
                        Php="2",
                        Wordpress="2",
                        Python="2",
                        Ruby="2",
                        Sqls="2",
                        Mysql="2",
                        Salesforce="2",
                        Photoshop="2",
                        Illustrator="2",
                        Seo="2",
                        Other="2"
                },
                new Knoledge {
                        Ionic="3",
                        Android="3",
                        Ios="3",
                        Html="3",
                        Css="3",
                        Bootstrap="3",
                        Jquery="3",
                        Angular="3",
                        Java="3",
                        Aspnet="3",
                        C="3",
                        Cpp="3",
                        Cake="3",
                        Django="3",
                        Majento="3",
                        Php="3",
                        Wordpress="3",
                        Python="3",
                        Ruby="3",
                        Sqls="3",
                        Mysql="3",
                        Salesforce="3",
                        Photoshop="3",
                        Illustrator="3",
                        Seo="3",
                        Other="3"
                }
        };
        var programmer = new Programmer[] {
                new Programmer {
                        Email="test1@example.com",
                        Name="Test 1",
                        Skype="test1.skp",
                        Phone="+123456",
                        Linkedin="linkedin.com/test1",
                        City="TestCity1",
                        State="TestState1",
                        Portfolio="test1.com",
                        Salary=80,
                        Bank="TestBank1",
                        Link="test1crud.com",
                        BankInfo=bankinfo[0],
                        Knoledge=knoledge[0],
                        BestTime=besttime[0],
                        Availability=availability[0]
                },
                new Programmer {
                        Email="test2@example.com",
                        Name="Test 2",
                        Skype="test2.skp",
                        Phone="+123456",
                        Linkedin="linkedin.com/test2",
                        City="TestCity2",
                        State="TestState2",
                        Portfolio="test2.com",
                        Salary=90,
                        Bank="TestBank2",
                        Link="test2crud.com",
                        BankInfo=bankinfo[1],
                        Knoledge=knoledge[1],
                        BestTime=besttime[1],
                        Availability=availability[1]
                },
                new Programmer {
                        Email="test3@example.com",
                        Name="Test 3",
                        Skype="test3.skp",
                        Phone="+123456",
                        Linkedin="linkedin.com/test3",
                        City="TestCity3",
                        State="TestState3",
                        Portfolio="test3.com",
                        Salary=100,
                        Bank="TestBank3",
                        Link="test3crud.com",
                        BankInfo=bankinfo[2],
                        Knoledge=knoledge[2],
                        BestTime=besttime[2],
                        Availability=availability[2]
                }
        };

        // foreach (Availability s in availability)
        // {
        //         context.Availability.Add(s);
        // }
        // foreach (BankInfo s in bankinfo)
        // {
        //         context.BankInfo.Add(s);
        // }
        // foreach (BestTime s in besttime)
        // {
        //         context.BestTime.Add(s);
        // }
        // foreach (Knoledge s in knoledge)
        // {
        //         context.Knoledge.Add(s);
        // }
        foreach (Programmer p in programmer)
        {
                context.Programmer.Add(p);
        }
        context.SaveChanges();
}
}
}
