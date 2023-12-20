namespace DescribeCompiler
{
    /// <summary>
    /// Those are different grammar files (.egt) for the Gold parser engine.
    /// Each of those files is stored as an embedded resource in the "Grammars" folder.
    /// </summary>
    public enum GrammarName
    {
        Basic,                       //0.6
        Tags,                        //0.7
        Links,                       //0.8
        Decorators,                  //0.9
        Official,                    //1.0
    }
}
