# Collision_Game

Simple Game to test the UI in Visual Studio 

the code for checking intraction 

```c#
        public bool checkIntract(Label label1, Label label2)
        {
            var rect1 = new System.Drawing.Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            var rect2 = new System.Drawing.Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            return rect1.IntersectsWith(rect2);
          
        }
```
