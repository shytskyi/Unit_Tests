using BL;

namespace UnitTestProject
{
    public class CulculatordoDawaniaLiczbTest
    {
        [Fact]
        public void DodawaniaLiczby_DwiePozytywneLiczby_ExceptedPozytewneZnacienia()
        {
            //Arrange
            int a = 1;
            int b = 2;
            
            //Act
            float result = Culculator.DodawaniaLiczby(a, b);

            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void DodawaniaLiczby_DwieNegatywneLiczby_ExceptedNegatywneZnacienia()
        {
            //Arrange
            int a = -1;
            int b = -2;

            //Act
            float result = Culculator.DodawaniaLiczby(a, b);

            //Assert
            Assert.Equal(-3, result);
        }

        [Fact]
        public void DodawaniaLiczby_JednaMniejszaNegatywnaDrugaWienkszPozytywnaLiczba_ExceptedPozytywneZnacienia()
        {
            //Arrange
            int a = -1;
            int b = 2;

            //Act
            float result = Culculator.DodawaniaLiczby(a, b);

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void DodawaniaLiczby_JednaMniejszaPozytywnaDrugaWienkszNegatywnaLiczba_ExceptedNegatywneZnacienia()
        {
            //Arrange
            int a = 1;
            int b = -2;

            //Act
            float result = Culculator.DodawaniaLiczby(a, b);

            //Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void DodawaniaLiczby_JednaWienkszPozytywnaDrugaMniejszaNegatywnaLiczba_ExceptedPozytywneZnacienia()
        {
            //Arrange
            int a = 2;
            int b = -1;

            //Act
            float result = Culculator.DodawaniaLiczby(a, b);

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void DodawaniaLiczby_JednaWienkszaNegatywnaDrugaMniejszaPozytywnaLiczba_ExceptedNegatywneZnacienia()
        {
            //Arrange
            int a = -2;
            int b = 1;

            //Act
            float result = Culculator.DodawaniaLiczby(a, b);

            //Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void DodawaniaLiczby_ZeroPlusZero_ExceptedZero()
        {
            //Arrange
            int a = 0;
            int b = 0;

            //Act
            float result = Culculator.DodawaniaLiczby(a, b);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void DodawaniaLiczby_DwieJedynkiPozytywna_i_Negatywna_ExceptedZero()
        {
            //Arrange
            int a = 1;
            int b = -1;

            //Act
            float result = Culculator.DodawaniaLiczby(a, b);

            //Assert
            Assert.Equal(0, result);
        }
    }
}