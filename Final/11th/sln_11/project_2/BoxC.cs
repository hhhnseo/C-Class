﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class BoxC
    {
        // 값을 안전하게 변경하기 위한 Getter와 Setter
        // 변수를 바로 변경할 수는 없지만 변수를 연결하는 메서드를 만들고 메서드를 호출해 변경

        // 겟터(Getter)
        private int width;
        private int height;

        public int Area() { return this.width * this.height; }

        public BoxC(int width, int height)  // 생성자
        {
            if (width > 0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이를 자연수로 초기화 해주세요.");
            }
        }
        public int getWidth(int width) { return width; }
        public int getHeight(int height) {  return height; }

        // 셋터(Setter)
        public void setWidth(int width) {
            if(width > 0) { this.width = width; }
            else { Console.WriteLine("너비는 자연수로 입력해 주세요."); }
        }
        public void setHeight(int height)
        {
            if (height > 0) { this.height = height; }
            else { Console.WriteLine("높이는 자연수로 입력해 주세요."); }
        }
    }
}
