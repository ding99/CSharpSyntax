using System;
using System.Collections.Generic;

namespace cList {

    public class DFile {
        public DFile prev;
        public DFile next;
        public string name;
        public long size;

        public DFile() {
            prev = null;
            next = null;
            name = String.Empty;
            size = 0;
        }
    }

    public class checkIndex {
        public checkIndex() {
        }

        public bool index() {
            List<DFile> fs = new List<DFile>();
            fs.Add(new DFile { name = "A", size = 100 });
            fs.Add(new DFile { name = "B", size = 200 });
            fs.Add(new DFile { name = "C", size = 300 });

            DFile tf, tf2;

            tf = fs[0]; fs[1].prev = tf;
            tf = fs[1]; fs[0].next = tf; fs[2].prev = tf;
            tf = fs[2]; fs[1].next = tf;

            tf2 = fs[2];
            tf = fs[0];
            tf2.next = tf;

            Console.WriteLine("=== fs [" + fs.Count + "] ===");
            foreach(DFile f in fs)
                Console.WriteLine(f.name + ", " + f.size + ", " +
                    (f.prev != null ? f.prev.name : "null") + ", " +
                    (f.next != null ? f.next.name : "null"));

            return true;
        }

        public bool which() {
            List<DFile> fs = new List<DFile>();
            fs.Add(new DFile { name = "A", size = 100 });
            fs.Add(new DFile { name = "B", size = 200 });
            fs.Add(new DFile { name = "C", size = 300 });

            Console.WriteLine("=== fs [" + fs.Count + "] ===");
            foreach(DFile f in fs)
                Console.WriteLine(f.name + ", " + f.size +
                    ", first " + (f == fs[0]) +
                    ", second " + (f == fs[1]) +
                    ", third " + (f == fs[2]));

            return true;
        }
    }
}
