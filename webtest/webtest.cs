namespace webtest
{
    public class webtest
    {
        [Fact]
        public void DemoTest()
        {
            int i = 1;
            bool result = false;
            if (i == 1) result = true;
            Assert.True(result, "value is equal to 1");
        }

        [Fact]
        public void checkAddFunction()
        {
            Functions func = new Functions();
            int y = func.add(2, 3);
            bool result = false;
            if (y==5) result = true;
            Assert.True(result, "value is equal to 5");
        }
    }
}