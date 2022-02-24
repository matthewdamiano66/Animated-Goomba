class Star{
    private int posX;
    private string[] starSprite;
    public Star(int PosX){
        this.posX = posX;
        starSprite = newString[6];
        SetSprite();//for store star image to starSprite.
    }
    private void setSprite(){
        starSprite[0] = @"          ";
        starSprite[1] = @"  ___/\___";
        starSprite[2] = @"  \  ||  / ";
        starSprite[3] = @"  /__  __\";
        starSprite[4] = @"     \/   ";
        starSprite[5] = @"          "; 
    }
    public void DrawSprite(){
        //draw starSprite at posX
        string spaces = ""; 
        for(int i =0; i<this.posX; i++)
        spaces +=" ";
        foreach(string eachline in starSprite)
        Console.WriteLine(spaces + eachLine);
    }
}