using NUnit.Framework;
using System;

namespace M3
{
    [TestFixture]
    public class Module3Tests
    {
        private Module3 _module;

        [SetUp]
        public void Setup()
        {
            _module = new Module3();
        }

        #region Задание 1: ReverseString Tests

        [Test]
        public void ReverseString_SimpleWord_ReturnsReversed()
        {
            Assert.AreEqual("olleH", _module.ReverseString("Hello"));
        }

        [Test]
        public void ReverseString_Palindrome_ReturnsSameString()
        {
            Assert.AreEqual("radar", _module.ReverseString("radar"));
        }

        [Test]
        public void ReverseString_EmptyString_ReturnsEmptyString()
        {
            Assert.AreEqual("", _module.ReverseString(""));
        }

        [Test]
        public void ReverseString_Null_ReturnsNull()
        {
            Assert.IsNull(_module.ReverseString(null));
        }

        [Test]
        public void ReverseString_SingleChar_ReturnsSameChar()
        {
            Assert.AreEqual("a", _module.ReverseString("a"));
        }

        #endregion

        #region Задание 2: IsPalindrome Tests

        [Test]
        public void IsPalindrome_PalindromeNumber_ReturnsTrue()
        {
            Assert.IsTrue(_module.IsPalindrome(121));
        }

        [Test]
        public void IsPalindrome_NonPalindromeNumber_ReturnsFalse()
        {
            Assert.IsFalse(_module.IsPalindrome(123));
        }

        [Test]
        public void IsPalindrome_NegativeNumber_ReturnsFalse()
        {
            Assert.IsFalse(_module.IsPalindrome(-121));
        }

        [Test]
        public void IsPalindrome_SingleDigit_ReturnsTrue()
        {
            Assert.IsTrue(_module.IsPalindrome(5));
        }

        [Test]
        public void IsPalindrome_Zero_ReturnsTrue()
        {
            Assert.IsTrue(_module.IsPalindrome(0));
        }

        [Test]
        public void IsPalindrome_LargePalindrome_ReturnsTrue()
        {
            Assert.IsTrue(_module.IsPalindrome(12321));
        }

        #endregion

        #region Задание 3: Factorial Tests

        [Test]
        public void Factorial_Zero_ReturnsOne()
        {
            Assert.AreEqual(1, _module.Factorial(0));
        }

        [Test]
        public void Factorial_One_ReturnsOne()
        {
            Assert.AreEqual(1, _module.Factorial(1));
        }

        [Test]
        public void Factorial_Five_Returns120()
        {
            Assert.AreEqual(120, _module.Factorial(5));
        }

        [Test]
        public void Factorial_Ten_Returns3628800()
        {
            Assert.AreEqual(3628800, _module.Factorial(10));
        }

        [Test]
        public void Factorial_NegativeNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _module.Factorial(-1));
        }

        #endregion

        #region Задание 4: IsPrime Tests

        [Test]
        public void IsPrime_Two_ReturnsTrue()
        {
            Assert.IsTrue(_module.IsPrime(2));
        }

        [Test]
        public void IsPrime_Three_ReturnsTrue()
        {
            Assert.IsTrue(_module.IsPrime(3));
        }

        [Test]
        public void IsPrime_Seven_ReturnsTrue()
        {
            Assert.IsTrue(_module.IsPrime(7));
        }

        [Test]
        public void IsPrime_One_ReturnsFalse()
        {
            Assert.IsFalse(_module.IsPrime(1));
        }

        [Test]
        public void IsPrime_Four_ReturnsFalse()
        {
            Assert.IsFalse(_module.IsPrime(4));
        }

        [Test]
        public void IsPrime_NegativeNumber_ReturnsFalse()
        {
            Assert.IsFalse(_module.IsPrime(-7));
        }

        [Test]
        public void IsPrime_LargePrime_ReturnsTrue()
        {
            Assert.IsTrue(_module.IsPrime(97));
        }

        #endregion

        #region Задание 5: Fibonacci Tests

        [Test]
        public void Fibonacci_Zero_ReturnsZero()
        {
            Assert.AreEqual(0, _module.Fibonacci(0));
        }

        [Test]
        public void Fibonacci_One_ReturnsOne()
        {
            Assert.AreEqual(1, _module.Fibonacci(1));
        }

        [Test]
        public void Fibonacci_Ten_Returns55()
        {
            Assert.AreEqual(55, _module.Fibonacci(10));
        }

        [Test]
        public void Fibonacci_Twenty_Returns6765()
        {
            Assert.AreEqual(6765, _module.Fibonacci(20));
        }

        [Test]
        public void Fibonacci_NegativeNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _module.Fibonacci(-1));
        }

        #endregion

        #region Задание 6: CountVowels Tests

        [Test]
        public void CountVowels_HelloWorld_Returns3()
        {
            Assert.AreEqual(3, _module.CountVowels("Hello World"));
        }

        [Test]
        public void CountVowels_AllVowels_Returns5()
        {
            Assert.AreEqual(5, _module.CountVowels("aeiou"));
        }

        [Test]
        public void CountVowels_NoVowels_ReturnsZero()
        {
            Assert.AreEqual(0, _module.CountVowels("bcdfg"));
        }

        [Test]
        public void CountVowels_EmptyString_ReturnsZero()
        {
            Assert.AreEqual(0, _module.CountVowels(""));
        }

        [Test]
        public void CountVowels_MixedCase_CountsBoth()
        {
            Assert.AreEqual(5, _module.CountVowels("AeIoU"));
        }

        #endregion

        #region Задание 7: GCD Tests

        [Test]
        public void GCD_48And18_Returns6()
        {
            Assert.AreEqual(6, _module.GCD(48, 18));
        }

        [Test]
        public void GCD_17And13_Returns1()
        {
            Assert.AreEqual(1, _module.GCD(17, 13));
        }

        [Test]
        public void GCD_SameNumbers_ReturnsSameNumber()
        {
            Assert.AreEqual(15, _module.GCD(15, 15));
        }

        [Test]
        public void GCD_OneIsZero_ReturnsOther()
        {
            Assert.AreEqual(5, _module.GCD(5, 0));
        }

        [Test]
        public void GCD_NegativeNumbers_ReturnsPositiveGCD()
        {
            Assert.AreEqual(6, _module.GCD(-48, 18));
        }

        #endregion

        #region Задание 8: AreAnagrams Tests

        [Test]
        public void AreAnagrams_ListenAndSilent_ReturnsTrue()
        {
            Assert.IsTrue(_module.AreAnagrams("listen", "silent"));
        }

        [Test]
        public void AreAnagrams_HelloAndWorld_ReturnsFalse()
        {
            Assert.IsFalse(_module.AreAnagrams("hello", "world"));
        }

        [Test]
        public void AreAnagrams_DifferentCase_ReturnsTrue()
        {
            Assert.IsTrue(_module.AreAnagrams("Listen", "Silent"));
        }

        [Test]
        public void AreAnagrams_WithSpaces_ReturnsTrue()
        {
            Assert.IsTrue(_module.AreAnagrams("a gentleman", "elegant man"));
        }

        [Test]
        public void AreAnagrams_DifferentLengths_ReturnsFalse()
        {
            Assert.IsFalse(_module.AreAnagrams("abc", "abcd"));
        }

        #endregion

        #region Задание 9: SumOfDigits Tests

        [Test]
        public void SumOfDigits_123_Returns6()
        {
            Assert.AreEqual(6, _module.SumOfDigits(123));
        }

        [Test]
        public void SumOfDigits_Zero_ReturnsZero()
        {
            Assert.AreEqual(0, _module.SumOfDigits(0));
        }

        [Test]
        public void SumOfDigits_NegativeNumber_ReturnsSumOfAbsolute()
        {
            Assert.AreEqual(6, _module.SumOfDigits(-123));
        }

        [Test]
        public void SumOfDigits_SingleDigit_ReturnsSameDigit()
        {
            Assert.AreEqual(7, _module.SumOfDigits(7));
        }

        #endregion

        #region Задание 10: FindMax Tests

        [Test]
        public void FindMax_NormalArray_ReturnsMax()
        {
            Assert.AreEqual(9, _module.FindMax(new[] { 1, 5, 3, 9, 2 }));
        }

        [Test]
        public void FindMax_SingleElement_ReturnsThatElement()
        {
            Assert.AreEqual(5, _module.FindMax(new[] { 5 }));
        }

        [Test]
        public void FindMax_NegativeNumbers_ReturnsMax()
        {
            Assert.AreEqual(-1, _module.FindMax(new[] { -5, -3, -1, -9 }));
        }

        [Test]
        public void FindMax_EmptyArray_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _module.FindMax(new int[0]));
        }

        #endregion

        #region Задание 11: IsSorted Tests

        [Test]
        public void IsSorted_SortedArray_ReturnsTrue()
        {
            Assert.IsTrue(_module.IsSorted(new[] { 1, 2, 3, 4, 5 }));
        }

        [Test]
        public void IsSorted_UnsortedArray_ReturnsFalse()
        {
            Assert.IsFalse(_module.IsSorted(new[] { 1, 3, 2, 4, 5 }));
        }

        [Test]
        public void IsSorted_SingleElement_ReturnsTrue()
        {
            Assert.IsTrue(_module.IsSorted(new[] { 1 }));
        }

        [Test]
        public void IsSorted_EmptyArray_ReturnsTrue()
        {
            Assert.IsTrue(_module.IsSorted(new int[0]));
        }

        [Test]
        public void IsSorted_WithDuplicates_ReturnsTrue()
        {
            Assert.IsTrue(_module.IsSorted(new[] { 1, 2, 2, 3, 3 }));
        }

        #endregion

        #region Задание 12: RemoveDuplicates Tests

        [Test]
        public void RemoveDuplicates_ArrayWithDuplicates_RemovesDuplicates()
        {
            var result = _module.RemoveDuplicates(new[] { 1, 2, 2, 3, 3, 3 });
            Assert.AreEqual(new[] { 1, 2, 3 }, result);
        }

        [Test]
        public void RemoveDuplicates_NoDuplicates_ReturnsSameArray()
        {
            var result = _module.RemoveDuplicates(new[] { 1, 2, 3 });
            Assert.AreEqual(new[] { 1, 2, 3 }, result);
        }

        [Test]
        public void RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
        {
            var result = _module.RemoveDuplicates(new int[0]);
            Assert.AreEqual(new int[0], result);
        }

        [Test]
        public void RemoveDuplicates_AllSame_ReturnsSingleElement()
        {
            var result = _module.RemoveDuplicates(new[] { 5, 5, 5, 5 });
            Assert.AreEqual(new[] { 5 }, result);
        }

        #endregion
    }
}

