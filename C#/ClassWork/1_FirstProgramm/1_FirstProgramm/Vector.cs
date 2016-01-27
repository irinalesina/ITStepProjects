using System;


namespace MyVector
{
    class Vector
    {
        int x, y, z;

        public Vector() { }

        public Vector(int vx, int vy, int vz)
        {
            x = vx;
            y = vy;
            z = vz;
        }

        public void Output()
        {
            Console.Write(x + "," + y + "," + z);
        }

        public static Vector Addition(Vector a, Vector b)
        {
            Vector res = new Vector();
            res.x = a.x + b.x;
            res.y = a.y + b.y;
            res.z = a.z + b.z;
            return res;
        }

        public static int ScalarProduct(Vector a, Vector b)
        {
            int res;
            res = a.x * b.x + a.y * b.y + a.z * b.z;
            return res;
        }

        public static Vector VectorProduct(Vector a, Vector b)
        {
            Vector res = new Vector();
            res.x = a.y * b.z - a.z * b.y;
            res.y = a.x * b.z - a.z * b.x;
            res.z = a.x * b.y - a.y * b.x;
            return res;
        }
    }
}
