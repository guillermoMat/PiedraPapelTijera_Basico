using PiedraPapelTijera;

namespace ComprobacionXunit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //variables 
            Juego obj = new Juego();
            Piedra objPiedra = new Piedra();
            Papel objPapel = new Papel();
            Tijera objTijera = new Tijera();

            string contra = "piedra";

            //act

            //Console.WriteLine("1-Piedra");
            //Console.WriteLine("2-Papel");
            //Console.WriteLine("3-Tijera");
            string resultado = obj.comprobacionJuego(1,contra);


            string result= (obj.comprobacionJuegoObjetos(objPiedra, objTijera));

            //assert
            Assert.Equal("Empate",resultado);
            Assert.Equal("Gana", result);




        }
    }
}