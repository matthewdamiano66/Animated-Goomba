class Ground{
    private int length;
    private string[] groundSprite;
    public ground(int length){
        this.length = length;
        groundSprite=new string[2];
        setSprite();
    }
    private void setSprite(){
        string grassOneLayer=""
        for (unt i =0; i<length;i++){
        grassOneLayer +=@"/"
    groundSprite[0]=grassOneLayer;
    groundSprite[1]=grassOneLayer;
    }
    public void DrawSprite(){
        foreach(string eachLine in groundSprite)
        Console.WriteLine(eachLine);
    }
}