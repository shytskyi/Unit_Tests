using BL;

namespace UnitTestProject
{
    public class NieparzysteLiczbyTablicyTest
    {
        [Fact]
        public void NieparzysteLiczbyTablicy_RozneLiczby_ExceptedLiczbyWienkszaOdZera_4()
        {
            //Arrange
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            //Act
            var result = NieparzysteLiczby.NieparzysteLiczbyTablicy(arr);

            //Assert
            Assert.Equal(4, result );
        }

        [Fact]
        public void NieparzysteLiczbyTablicy_tablicaPusta_ExceptedZero()
        {
            //Arrange
            int[] arr = { };

            //Act
            var result = NieparzysteLiczby.NieparzysteLiczbyTablicy(arr);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void NieparzysteLiczbyTablicy_TylkoPazysteLiczby_ExceptedZero()
        {
            //Arrange
            int[] arr = { 2, 4, 6 };

            //Act
            var result = NieparzysteLiczby.NieparzysteLiczbyTablicy(arr);

            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void NieparzysteLiczbyTablicy_TylkoNiePazysteLiczby_ExceptedTrzy()
        {
            //Arrange
            int[] arr = { 1, 3, 5 };

            //Act
            var result = NieparzysteLiczby.NieparzysteLiczbyTablicy(arr);

            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void NieparzysteLiczbyTablicy_NegatywneRozneLiczby_ExceptedLiczbyWienkszaOdZera_4()
        {
            //Arrange
            int[] arr = { -1, -2, -3, -4, -5, -6, -7, -8 };

            //Act
            var result = NieparzysteLiczby.NieparzysteLiczbyTablicy(arr);

            //Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void NieparzysteLiczbyTablicy_NegatywnePozytywneRozneLiczby_ExceptedLiczbyWienkszaOdZera_4()
        {
            //Arrange
            int[] arr = { -1, -2, 3, 4, -5, -6, 7, -8 };

            //Act
            var result = NieparzysteLiczby.NieparzysteLiczbyTablicy(arr);

            //Assert
            Assert.Equal(4, result);
        }
    }
}
