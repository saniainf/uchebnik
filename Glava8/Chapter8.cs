using System;

class Chapter8
{
    public Chapter8()
    {
        MainService.PrintF("afafasfasfasf\n");
        MainService.PrintF(123123 + "\n");
        MainService.PrintF(88888888);

        MainService.PrintF();

        MainService.PrintF(MainService.IsEven(88));
        MainService.PrintF(MainService.IsEven(99));

        MainService.PrintF();

        MainService.PrintF(MainService.IsOdd(88));
        MainService.PrintF(MainService.IsOdd(99));

        MainService.PrintF();

        MainService.PrintCount();
    }
}