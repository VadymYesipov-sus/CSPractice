using Practice13;

Gun gun = new Gun();
Gun pistol = new Pistol();
gun.Shoot();
gun.ToggleSafety();
gun.Shoot();
pistol.ToggleSafety();
pistol.GunBrand = "COLT1911";
pistol.Shoot();
//casting to the derived type
//Pistol myPistol = (Pistol)pistol;

//SAFE CASTING, isntead of exception it will return null if object has wrong type
//not for myself - Avoid Unnecessary Casting
Pistol myPistol = pistol as Pistol;
if (myPistol != null)
{
    myPistol.ShootWithSilencer();  // Output: The dog barks.
}
else
{
    Console.WriteLine("This gun is not a pistol.");
}
