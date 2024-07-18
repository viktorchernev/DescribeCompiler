namespace DescribeTranspiler
{
    /// <summary>
    /// Those are different grammar files (.egt) for the Gold parser engine.
    /// Each of those files is stored as an embedded resource in the "Grammars" folder.
    /// </summary>
    public enum DescribeVersionName
    {
        Basics,                      //0.6
        Tags,                        //0.7
        Links,                       //0.8
        Decorators,                  //0.9

        Lines,                       //1.0 aka. Official
        Doubles,                     //1.1
    }
}
