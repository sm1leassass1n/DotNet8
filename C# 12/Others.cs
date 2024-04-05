
//inline arrays - they have a set size for performance

//I don't currently understand what this means
//"You likely won't declare your own inline arrays, but you use them transparently
//when they're exposed as System.Span<T> or System.ReadOnlySpan<T> objects from
//runtime APIs".

//not used span or readonlyspan.

//inline array example
[System.Runtime.CompilerServices.InlineArray(10)]
public struct Buffer
{
    private int _element0;
}


//Experimental attribute
//for methods types and assemblies - nice warning before someone uses your method
//like 'obsolete'

[Experimental("")]
public static void FindFood()
{

}