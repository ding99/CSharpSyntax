using System;
using System.Collections.Generic;

namespace List {
    public class NPV {

        public class ASegment {
            public double Start;
            public double End;
            public double Duration;

            public ASegment() {
                Start = .0;
                End = .0;  // last blank + 1
                Duration = .0;
            }
        }

        #region segment
        private List<ASegment> margeSilence(List<ASegment> s1, List<ASegment> s2) {
            List<ASegment> rs = new List<ASegment>();
            int b1 = 0, b2 = 0;
            bool brk = false;

            ASegment m1 = new ASegment(), seg = new ASegment();

            while(b1 < s1.Count && b2 < s2.Count) {

                brk = false;

                for(int i = b1; i < s1.Count; i++) {

                    for(int j = b2; j < s2.Count; j++) {
                        if(s2[j].Start < s1[i].Start) {
                            if(s2[j].End <= s1[i].Start) {
                                b2++;
                                continue;
                            } else if(s2[j].End <= s1[i].End) {
                                rs.Add(new ASegment {
                                    Start = s1[i].Start, End = s2[j].End, Duration = s2[j].End - s1[i].Start
                                });
                                if(s2[j].End < s1[i].End)
                                    s1[i].Start = s2[j].End;
                                else
                                    b1++;
                                b2++;
                                brk = true;
                                break;
                            } else {
                                rs.Add(new ASegment {
                                    Start = s1[i].Start, End = s1[i].End, Duration = s1[i].End - s1[i].Start
                                });
                                s2[j].Start = s1[i].End;
                                b1++;
                                brk = true;
                                break;
                            }
                        } else if(s2[j].Start < s1[i].End) {
                            if(s2[j].End <= s1[i].End) {
                                rs.Add(new ASegment {
                                    Start = s2[j].Start, End = s2[j].End, Duration = s2[j].End - s2[j].Start
                                });
                                if(s2[j].End < s1[i].End)
                                    s1[i].Start = s2[j].End;
                                else
                                    b1++;
                                b2++;
                                brk = true;
                                break;
                            } else {
                                rs.Add(new ASegment {
                                    Start = s2[j].Start, End = s1[i].End, Duration = s1[i].End - s2[j].Start
                                });
                                s2[j].Start = s1[i].End;
                                b1++;
                                brk = true;
                                break;
                            }
                        } else {
                            b1++;
                            brk = true;
                            break;
                        }
                    }

                    if(brk)
                        break;
                }
            }

            return rs;
        }

        private void dsplist(List<ASegment> l, string m) {
            Console.WriteLine("--- " + m + " --- ( size : " + l.Count + " )");
            foreach(ASegment a in l)
                Console.WriteLine(String.Format("  {0, 6:0.000} / {1, 6:0.000}  {2, 6:0.000}", a.Start, a.End, a.Duration));
        }

        public void commonList() {
            List<ASegment> l1 = new List<ASegment> {
                new ASegment{ Start = 5.0, End = 10.0, Duration = 5.0 },
                new ASegment{ Start = 15.0, End = 20.0, Duration = 5.0 },
                new ASegment{ Start = 25.0, End = 30.0, Duration = 5.0 }
            };
            List<ASegment> l2 = new List<ASegment> {
                new ASegment{ Start = 1.0, End = 2.0, Duration = 1.0 },
                new ASegment{ Start = 3.0, End = 6.0, Duration = 3.0 },
                new ASegment{ Start = 7.5, End = 16.0, Duration = 8.5 },
                new ASegment{ Start = 17.5, End = 36.0, Duration = 18.5 }
            };
            List<ASegment> l3 = new List<ASegment> {
                new ASegment{ Start = 5.5, End = 15.5, Duration = 1.0 },
                new ASegment{ Start = 16.1, End = 16.5, Duration = 3.0 },
                new ASegment{ Start = 17.5, End = 26.0, Duration = 8.5 },
                new ASegment{ Start = 27.5, End = 28.0, Duration = 18.5 },
                new ASegment{ Start = 57.5, End = 58.0, Duration = 18.5 }
            };
            dsplist(l1, "List 1");
            dsplist(l2, "List 2");
            dsplist(l3, "List 3");

            List<ASegment> ln = this.margeSilence(l1, l2);
            dsplist(ln, "New 1-2");
            dsplist(this.margeSilence(ln, l3), "New 123");
        }
        #endregion

        public NPV() {
            Console.ForegroundColor = ConsoleColor.Green;
        }

    }
}
