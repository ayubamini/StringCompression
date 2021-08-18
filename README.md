# StringCompression
A simple program in .NET 5.0 and unit testing that compresses an alphabetical string by collapsing consecutive characters. The rules
of the compression algorithm are defined by the test cases below.

# Test cases:
    1. Input: aaabccccdd
       Output : a3bc4d2

    2. Input: yyyyyzzzzzzzzzz
       Output: y5z10

    3. Input: abcd
       Output: abcd (note: not a1b1c1d1)

    4. Input: hhhccchhhccc
       Output: h3c3h3c3
