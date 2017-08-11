var target = Argument("target", "Default");

Task("Default")
	.Does(() =>
{
	Information("Cake build script is in progress..");
});

RunTarget(target);
	
