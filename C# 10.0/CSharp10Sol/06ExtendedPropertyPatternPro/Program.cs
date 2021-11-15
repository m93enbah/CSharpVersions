//support lamda search expression allow you to search deeper on sub prop in new simle format
using _06ExtendedPropertyPatternPro;

var innerRect = new Rectangle(100, 100);
var rect = new Rectangle(200, 300, innerRect);

if (rect is { rect1: { height: > 100 } }) 
{

}

//In C Sharp 10 lamda search expression like below simple
if (rect is { rect1.height: > 100 })
{
}

//or using old way
if (rect?.rect1?.height > 100) 
{
}