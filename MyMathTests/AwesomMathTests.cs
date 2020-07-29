using MyMath;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MyMathTests
{
    public class AwesomMathTests
    {

        [Fact(DisplayName = "Given the number 40 should return a list containing 8 divisor")]
        public void GivenSmallNumberShouldReturnListWithNumbers()
        {
            //arrange
            int number = 40;

            //act
            var actualDivisor = AwesomeMath.GetDivisor(number);

            //assert
            Assert.Equal(8, actualDivisor.Count());
        }

        [Fact(DisplayName = "Given the number 40 should return a list and match with the specified 8 divisor")]
        public void GivenSmallNumerShouldReturnListAndMatchWithSpecifiedNumbers()
        {
            //arrange
            int number = 40;
            var expectedDivisor = new List<int> { 1, 2, 4, 5, 8, 10, 20, 40 };

            //act
            var actualDivisor = AwesomeMath.GetDivisor(number);

            //assert
            Assert.Equal(expectedDivisor, actualDivisor);
        }

        [Fact(DisplayName = "Given the number int.Max -1 should return a list containing 192 divisor")]
        public void GivenBigNumberShouldReturnListWithNumbers()
        {
            //arrange
            int number = int.MaxValue-1;

            //act
            var actualDivisor = AwesomeMath.GetDivisor(number);

            //assert
            Assert.Equal(192, actualDivisor.Count());
        }

        [Fact(DisplayName = "Given the number int.Max -1 should return a list and match with the specified 192 divisor")]
        public void GivenBigNumberShouldReturnListAndMatchWithSpecifiedNumbers()
        {
            //arrange
            int number = int.MaxValue - 1;

            var expectedDivisor = new List<int> { 1, 2, 3, 6, 7, 9, 11, 14,
            18, 21, 22, 31, 33, 42, 62, 63, 66, 77, 93, 99, 126, 151, 154, 186, 198, 217, 231,
            279, 302, 331, 341, 434, 453, 462, 558, 651, 662, 682, 693, 906, 993, 1023, 1057, 1302,
            1359, 1386, 1661, 1953, 1986, 2046, 2114, 2317, 2387, 2718, 2979, 3069, 3171, 3322, 3641,
            3906, 4634, 4681, 4774, 4983, 5958, 6138, 6342, 6951, 7161, 7282, 9362, 9513, 9966, 10261,
            10923, 11627, 13902, 14043, 14322, 14949, 19026, 20522, 20853, 21483, 21846, 23254, 25487,
            28086, 29898, 30783, 32767, 32769, 34881, 41706, 42129, 42966, 49981, 50974, 51491, 61566,
            65534, 65538, 69762, 71827, 76461, 84258, 92349, 98301, 99962, 102982, 104643, 112871, 143654,
            149943, 152922, 154473, 184698, 196602, 209286, 215481, 225742, 229383, 294903, 299886, 308946,
            338613, 349867, 360437, 430962, 449829, 458766, 463419, 549791, 589806, 646443, 677226, 699734,
            720874, 790097, 899658, 926838, 1015839, 1049601, 1081311, 1099582, 1292886, 1549411, 1580194,
            1649373, 2031678, 2099202, 2162622, 2370291, 3098822, 3148803, 3243933, 3298746, 3848537, 4648233,
            4740582, 4948119, 6297606, 6487866, 7110873, 7697074, 9296466, 9896238, 10845877, 11545611, 13944699,14221746,
            17043521, 21691754, 23091222, 27889398, 32537631, 34087042, 34636833, 51130563, 65075262,69273666,
            97612893, 102261126, 119304647, 153391689, 195225786, 238609294, 306783378, 357913941, 715827882, 1073741823, 2147483646 };

            //act
            var actualDivisor = AwesomeMath.GetDivisor(number);

            //assert
            Assert.Equal(expectedDivisor, actualDivisor);
        }




    }
}