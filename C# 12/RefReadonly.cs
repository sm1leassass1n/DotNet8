//example from docs
public static void ForceByRef(ref readonly OptionStruct thing)
{
    // elided
}



//my best understanding of this feature is that it is meant to force
//the dev using 'ForceByRef' to pass a variable.

//The docs put this near the 'in' paramater modifier which I haven't used before

//but reading the docs say that the variable is passed in by refrence which eliminates
//the need to create a copy and pass by value. very nice