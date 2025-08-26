Console.Clear();

var permission = "Admin";
var level = 15;
var mensaje = "You do not have sufficient privileges.";

if (permission.Contains("Admin"))
{ mensaje = level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user."; }
else if (permission.Contains("Manager"))
{ mensaje = level > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges."; }

Console.WriteLine(mensaje);


