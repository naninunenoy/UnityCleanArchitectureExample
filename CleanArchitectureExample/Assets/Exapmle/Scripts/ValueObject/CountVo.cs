using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Example {
    public class CountVo {
        public int Count { private set; get; }
        public CountVo(int count) {
            Count = count;
        }
        public void Add() {
            Count++;
        }
    }
}
