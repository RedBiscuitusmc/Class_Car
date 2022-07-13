using Carsexe;

/*.=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= -.
   /------------------------------ \
  |     By                                     |
  |     Jacob Merlin                   |
   \------------------------------ /
                 !           ! 
                !           !
                !          !
               ! _       !
         /   !__)     !
 __/___/_____)
        (_______)
 ___(______)
      \_(____)
         !       !
         !      !
         \__/
'-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-='*/

namespace Classesexe
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var Model = new Car();
            var Make = new Car();
            var Year = new Car();

            Car.Make = "Ford";
            Car.Model = "Ranger";
            Car.Year = 2004;

            Console.WriteLine(Car.Make);
            Console.WriteLine(Car.Model);
            Console.WriteLine(Car.Year);
        }
    }
}