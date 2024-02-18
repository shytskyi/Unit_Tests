using BL;

namespace UnitTestProject
{
    public class CulculatorDzieleniaLiczb
    {
        [Fact]
        public void DzieleniaLiczb_DwiePozytywneLiczby_ExceptedPozytewneZnacienia()
        {
            //Arrange
            int a = 1;
            int b = 2;

            //Act
            double result = Culculator.DzieleniaLiczb(a, b);

            //Assert
            Assert.Equal(0.5, result);
        }

        [Fact]
        public void DzieleniaLiczb_DwieNegatywnychLiczby_ExceptedPozytewneZnacienia()
        {
            //Arrange
            int a = -1;
            int b = -2;

            //Act
            double result = Culculator.DzieleniaLiczb(a, b);

            //Assert
            Assert.Equal(0.5, result);
        }

        [Fact]
        public void DzieleniaLiczb_PozytywnaNaNegatywna_ExceptedNegatywneZnacienia()
        {
            //Arrange
            int a = 1;
            int b = -2;

            //Act
            double result = Culculator.DzieleniaLiczb(a, b);

            //Assert
            Assert.Equal(-0.5, result);
        }

        [Fact]
        public void DzieleniaLiczb_DzieleniaNaZero_ExceptedException()
        {
            //Arrange
            int a = 1;
            int b = 0;

            //Act & Assert
            Assert.Throws<DivideByZeroException>(() => Culculator.DzieleniaLiczb(a, b));
        }


        [Fact]
        public void DzieleniaLiczb_DzieleniaNaPozytynaJedynke_ExceptedPozytewneZnacienia()
        {
            //Arrange
            int a = 1;
            int b = 1;

            //Act
            double result = Culculator.DzieleniaLiczb(a, b);

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void DzieleniaLiczb_DzieleniaNanegatynaJedynke_ExceptedNegatywneZnacienia()
        {
            //Arrange
            int a = 1;
            int b = -1;

            //Act
            double result = Culculator.DzieleniaLiczb(a, b);

            //Assert
            Assert.Equal(-1, result);
        }
    }
}
