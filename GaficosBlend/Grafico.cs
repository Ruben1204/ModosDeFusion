using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModosDeFusionT.GaficosBlend
{
    internal class Grafico : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            PointF center = new PointF(dirtyRect.Center.X, dirtyRect.Center.Y);//creamos un punto llamado center con coordenadas x,y que estan en el centro del rectangulo que dibujemos.
            float radius = Math.Min(dirtyRect.Width, dirtyRect.Height) / 4;//aqui calculamos el radio como una cuarta parte del minimo entre el ancho y el alto del ractangulo dirtyrect
            float distance = 0.8f * radius;//hacemos calculo del 80% del radio calculado anteriormente

            //calculamos tres puntos adicionales para dibujar 3 circulos teniendo en cuenta el centro del reactangulo o area anteriormente

            PointF center1 = new PointF(distance * (float)Math.Cos(9 * Math.PI / 6) + center.X,
                distance * (float)Math.Sin(9 * Math.PI / 6) + center.Y);//aqui calculamos un punto central nuevo a una distancia de 80% del radiu calculado anteriormente y con un angulo de 270 grados respecto al eje horizontal
            PointF center2 = new PointF(distance * (float)Math.Cos(1 * Math.PI / 6) + center.X,
                distance * (float)Math.Sin(1 * Math.PI / 6) + center.Y);//60 grados
            PointF center3 = new PointF(distance * (float)Math.Cos(5 * Math.PI / 6) + center.X,
                distance * (float)Math.Sin(5 * Math.PI / 6) + center.Y);//150 grados

            canvas.BlendMode = BlendMode.PlusDarker;//aqui configuramos el modo de mezcla del lienzo; esto afectara como se combinan los colores al dibujar

            canvas.FillColor = Colors.Cyan;//damos un color al circulo que dibujaremos
            canvas.FillCircle(center1, radius);//y dibujamos el primer circulo

            canvas.FillColor = Colors.Magenta;//damos un color al segundo circulo que dibujaremos
            canvas.FillCircle(center2, radius);//y dibujamos el segundo circulo

            canvas.FillColor = Colors.Yellow;//damos un color al tercer circulo que dibujaremos
            canvas.FillCircle(center3, radius);//y dibujamos el tercer circulo
        }
    }
}
