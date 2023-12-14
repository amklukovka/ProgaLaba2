using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using ConsoleApp22.Laba2;

namespace Laba2.Tests
{
    public class ContactTests
    {
        // тест для конструктора Contact
        [Fact]
        public void Test_Contact_Constructor()
        {
            // ñîçäàåì ýêçåìïëÿð êëàññà Contact ñ çàäàííûìè ïàðàìåòðàìè
            Contact contact = new Contact("Òîíè", "Ñòàðê", "+71234567899", "tonystark@gmail.com");

            // ïðîâåðÿåì, ÷òî ïîëÿ êëàññà Contact ñîîòâåòñòâóþò çàäàííûì ïàðàìåòðàì
            Assert.Equal("Òîíè", contact.Name);
            Assert.Equal("Ñòàðê", contact.Surname);
            Assert.Equal("+71234567899", contact.Phone);
            Assert.Equal("tonystark@gmail.com", contact.Email);
        }

        // òåñò äëÿ ìåòîäà Show
        [Fact]
        public void Test_Show()
        {
            // ñîçäàåì ýêçåìïëÿð êëàññà Contact ñ çàäàííûìè ïàðàìåòðàìè
            Contact contact = new Contact("Ïèòåð", "Ïàðêåð", "+73216549877", "peterparker@gmail.com");

            // ïåðåíàïðàâëÿåì ñòàíäàðòíûé âûâîä â ñòðîêîâûé ïèñàòåëü
            using (System.IO.StringWriter sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw); // ïåðåíàïðàâëÿåì ïîòîê âûâîäà íà îáúåêò
                contact.Show(); // âûçûâàåì ìåòîä Show äëÿ êîíòàêòà

                Console.SetOut(Console.Out); // âîññòàíàâëèâàåì ñòàíäàðòíûé âûâîä íà êîíñîëü
                string output = sw.ToString(); // ïîëó÷àåì ñòðîêó, êîòîðàÿ áûëà âûâåäåíà ìåòîäîì Show

                // ïðîâåðÿåì, ÷òî ñòðîêà ñîäåðæèò îæèäàåìûå äàííûå êîíòàêòà
                Assert.Contains("Name: Ïèòåð", output);
                Assert.Contains("Surname: Ïàðêåð", output);
                Assert.Contains("Phone: +73216549877", output);
                Assert.Contains("E-mail: peterparker@gmail.com", output);
            }
        }
    }
}
