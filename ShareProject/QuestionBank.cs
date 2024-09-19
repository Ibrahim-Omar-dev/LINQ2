using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareProject
{
    public static class QuestionBank
    {
        private static Random random = new Random();

        public static IEnumerable<Question> Randomize(int count)
        {
            if (All.Count < count) return All;
            return AllShuffled.Take(count);
        }

        public static Question PickOne()
        {
            return All[random.Next(0, All.Count)];
        }

        public static void ToQuiz(this IEnumerable<Question> questions)
        {
            foreach (var question in questions)
            {
                Console.WriteLine(question);
                Console.WriteLine();

            }
        }

        public static List<Question> GetQuestionRange(IEnumerable<int> range)
        {
            return All.Where((x, i) => range.Contains(i)).ToList();
        }

        public static List<Question> All => new List<Question>() {
      // Question #1

      new Question {
        Title = "Q #1: In the streaming stored audio/video category of audio/video services",
        CorrectAnswer = 1,
        Marks = 7,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "Files are compressed and stored on the server"
          },
          new Choice {
            Order = 2,
            Description = "A user listens to a broadcast audio and video through the internet"
          },
          new Choice {
            Order = 3,
            Description = "People use the Internet to interactively communicate with one another"
          },
          new Choice {
            Order = 4,
            Description = "None of the above"
          }
        }
      },
      new Question {
        Title = "Q #2: In the streaming live audio/video category of audio/video services",
        CorrectAnswer = 1,
        Marks = 4,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "Files are compressed and stored on the server"
          },
          new Choice {
            Order = 2,
            Description = "A user listens to a broadcast audio and video through the internet"
          },
          new Choice {
            Order = 3,
            Description = "People use the Internet to interactively communicate with one another"
          },
          new Choice {
            Order = 4,
            Description = "None of the above"
          }
        }
      },
      new Question {
        Title = "Q #3: In the interactive audio/video category of audio/video services",
        CorrectAnswer = 1,
        Marks = 1,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "Files are compressed and stored on the server"
          },
          new Choice {
            Order = 2,
            Description = "A user listens to a broadcast audio and video through the internet"
          },
          new Choice {
            Order = 3,
            Description = "People use the Internet to interactively communicate with one another"
          },
          new Choice {
            Order = 4,
            Description = "None of the above"
          }
        }
      },
      new Question {
        Title = "Q #4: Streaming stored audio/video is sometimes referred to as on-demand audio/video",
        CorrectAnswer = 1,
        Marks = 3,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #5: An example of streaming stored audio/video is Internet radio",
        CorrectAnswer = 1,
        Marks = 9,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #6: Streaming live audio/video refers to on-demand requests for compressed audio/video",
        CorrectAnswer = 1,
        Marks = 2,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #7: An example of interactive audio/video is Internet teleconferencing",
        CorrectAnswer = 1,
        Marks = 9,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #8: A raw piece of information, whether audio or video, must be compressed and then digitized",
        CorrectAnswer = 1,
        Marks = 2,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #9: A raw piece of information, whether audio or video, must be digitized and then compressed",
        CorrectAnswer = 1,
        Marks = 9,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #10: Digitization refers to",
        CorrectAnswer = 1,
        Marks = 5,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "Conversion to a stream of numbers, and preferably these numbers should be integers for efficiency"
          },
          new Choice {
            Order = 2,
            Description = "The process of coding that will effectively reduce the total number of bits needed to represent certain information"
          },
          new Choice {
            Order = 3,
            Description = "The process of converting information into an analog format"
          },
          new Choice {
            Order = 4,
            Description = "Conversion to a stream of numbers, and preferably these numbers should be decimals for efficiency"
          }
        }
      },
      new Question {
        Title = "Q #11: Compression refers to",
        CorrectAnswer = 1,
        Marks = 3,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "Conversion to a stream of numbers, and preferably these numbers should be integers for efficiency"
          },
          new Choice {
            Order = 2,
            Description = "The process of coding that will effectively reduce the total number of bits needed to represent certain information"
          },
          new Choice {
            Order = 3,
            Description = "The process of converting information into an analog format"
          },
          new Choice {
            Order = 4,
            Description = "Conversion to a stream of numbers, and preferably these numbers should be decimals for efficiency"
          }
        }
      },
      new Question {
        Title = "Q #12: Analog frequencies represents the sound frequency as a function of time",
        CorrectAnswer = 1,
        Marks = 3,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #13: Analog frequencies represents the sound amplitude as a function of time",
        CorrectAnswer = 1,
        Marks = 5,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #14: To digitize an analog signal, the signal must be sampled in the dimension of time, as well as the dimension of amplitude",
        CorrectAnswer = 1,
        Marks = 8,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #15: To digitize an analog signal, the signal must be sampled in the dimension of time, as well as the dimension of frequency",
        CorrectAnswer = 1,
        Marks = 6,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #16: Quantization refers to",
        CorrectAnswer = 1,
        Marks = 8,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "Sampling in the voltage dimension"
          },
          new Choice {
            Order = 2,
            Description = "Sampling in the frequency dimension"
          },
          new Choice {
            Order = 3,
            Description = "Sampling in the time dimension"
          },
          new Choice {
            Order = 4,
            Description = "Sampling in the bitrate dimension"
          }
        }
      },
      new Question {
        Title = "Q #17: Sampling referes to the process of sampling the time dimension",
        CorrectAnswer = 1,
        Marks = 3,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #18: Sampling referes to the process of sampling the amplitude dimension",
        CorrectAnswer = 1,
        Marks = 9,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #19: Nyquist thereom states",
        CorrectAnswer = 1,
        Marks = 9,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "If the highest frequency of the signal is f, we need to sample the signal 2f times per second"
          },
          new Choice {
            Order = 2,
            Description = "If the highest frequency of the signal is f, we need to sample the signal f times per second"
          },
          new Choice {
            Order = 3,
            Description = "If the highest frequency of the signal is f, we need to sample the signal 3f times per second"
          },
          new Choice {
            Order = 4,
            Description = "If the highest frequency of the signal is f, we need to sample the signal 4f times per second"
          }
        }
      },
      new Question {
        Title = "Q #20: The process of converting from analog audio to compressed binary form sampling quantization, and encoding is known as:",
        CorrectAnswer = 1,
        Marks = 4,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "Pulse code modulation"
          },
          new Choice {
            Order = 2,
            Description = "Polar quantization"
          },
          new Choice {
            Order = 3,
            Description = "Pulse code quantization"
          },
          new Choice {
            Order = 4,
            Description = "Polar code modulation"
          }
        }
      },
      new Question {
        Title = "Q #21: A video consists of a sequence of frames",
        CorrectAnswer = 1,
        Marks = 8,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #22: The standard number of frames per second of a video is 25 frames per second",
        CorrectAnswer = 1,
        Marks = 1,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #23: In North America, a common number of frames per second _________ frames per second",
        CorrectAnswer = 1,
        Marks = 6,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "20"
          },
          new Choice {
            Order = 2,
            Description = "35"
          },
          new Choice {
            Order = 3,
            Description = "25"
          },
          new Choice {
            Order = 4,
            Description = "30"
          }
        }
      },
      new Question {
        Title = "Q #24: To avoid a condition called flickering, a frame needs to be refreshed",
        CorrectAnswer = 1,
        Marks = 1,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #25: Pixels are also known as picture elements",
        CorrectAnswer = 1,
        Marks = 2,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #26: For colour TV, each pixel represents 8 bits",
        CorrectAnswer = 1,
        Marks = 4,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #27: For black and white TV, each pixel represents 8 bits",
        CorrectAnswer = 1,
        Marks = 5,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #28: For colour TV, each pixel designates 8 bits for each primary colour (red, blue, yellow)",
        CorrectAnswer = 1,
        Marks = 7,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #29: A video's dimensions are 1920x1080 pixels (in colour), and is played at 25 frames per second (with refreshing). This means we need a ___________ Mbps bitrate",
        CorrectAnswer = 1,
        Marks = 1,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "944"
          },
          new Choice {
            Order = 2,
            Description = "2488"
          },
          new Choice {
            Order = 3,
            Description = "1024"
          },
          new Choice {
            Order = 4,
            Description = "2048"
          }
        }
      },
      new Question {
        Title = "Q #30: In ______________ encoding, the differences between the samples are encoded instead of encoding all the sampled values",
        CorrectAnswer = 1,
        Marks = 5,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "Predictive"
          },
          new Choice {
            Order = 2,
            Description = "Perceptual"
          },
          new Choice {
            Order = 3,
            Description = "Perpetual"
          },
          new Choice {
            Order = 4,
            Description = "Compressed"
          }
        }
      },
      new Question {
        Title = "Q #31: Predictive encoding is often used for creating CD-quality audio",
        CorrectAnswer = 1,
        Marks = 7,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #32: Predictive encoding is often used for speech",
        CorrectAnswer = 1,
        Marks = 1,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #33: The idea of _____________ encoding is based on the limitations of our auditory system",
        CorrectAnswer = 1,
        Marks = 8,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "Predictive"
          },
          new Choice {
            Order = 2,
            Description = "Perceptual"
          },
          new Choice {
            Order = 3,
            Description = "Perpetual"
          },
          new Choice {
            Order = 4,
            Description = "Compressed"
          }
        }
      },
      new Question {
        Title = "Q #34: Perceptual encoding is often used for creating CD-quality audio",
        CorrectAnswer = 1,
        Marks = 3,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #35: Perceptual encoding is often used for speech",
        CorrectAnswer = 1,
        Marks = 5,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #36: MP3 uses predictive encoding",
        CorrectAnswer = 1,
        Marks = 3,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #37: JPEG is a standard which is used to compress images",
        CorrectAnswer = 1,
        Marks = 5,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #38: MPEG is a standard which is used to compress audio",
        CorrectAnswer = 1,
        Marks = 7,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #39: JPEG works by",
        CorrectAnswer = 1,
        Marks = 3,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "Changing the picture into a linear set of numbers so that redundancies can be found and removed"
          },
          new Choice {
            Order = 2,
            Description = "Partitioning the picture into I-frames, P-frames, and B-frames"
          },
          new Choice {
            Order = 3,
            Description = "Changing the colour of pixels that are similar to the colour of other pixels so they are the same"
          },
          new Choice {
            Order = 4,
            Description = "Changing the size of the picture so that it is smaller"
          }
        }
      },
      new Question {
        Title = "Q #40: The steps for JPEG compression are (in order from first to last)",
        CorrectAnswer = 1,
        Marks = 1,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "DCT, Quantization, Data Compression"
          },
          new Choice {
            Order = 2,
            Description = "Quantization, DCT, Data Compression"
          },
          new Choice {
            Order = 3,
            Description = "DCT, Data Compression, Quantization"
          },
          new Choice {
            Order = 4,
            Description = "Data Compression, Quantization, DCT"
          }
        }
      },
      new Question {
        Title = "Q #41: Discrete cosine transformation changes a block of 64 values so that the relative relationships between pixels are kept but the redundancies are revealed ",
        CorrectAnswer = 1,
        Marks = 2,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #42: DCT is irreversable ",
        CorrectAnswer = 1,
        Marks = 6,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #43: In DCT, the value T(0, 0) in the transformation table is called the AC value",
        CorrectAnswer = 1,
        Marks = 3,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #44: In DCT, the value T(0, 0) in the transformation table is called the DC value",
        CorrectAnswer = 1,
        Marks = 6,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #45: In DCT, the value T(m, n), exluding the value T(0, 0) in the transformation table, is called the AC value",
        CorrectAnswer = 1,
        Marks = 7,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #46: In DCT, the DC values are the changes in the colours of the pixels",
        CorrectAnswer = 1,
        Marks = 3,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #47: In DCT, the DC value is the average value (multiplied by a constant) of the pixels",
        CorrectAnswer = 1,
        Marks = 9,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #48: JPEG compression is called \"lossy\" because of the",
        CorrectAnswer = 1,
        Marks = 3,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "DCT phase"
          },
          new Choice {
            Order = 2,
            Description = "Quantization phase"
          },
          new Choice {
            Order = 3,
            Description = "Compression phase"
          },
          new Choice {
            Order = 4,
            Description = "JPEG is not \"lossy\""
          }
        }
      },
      new Question {
        Title = "Q #49: For JPEG compression, the compression phase is read",
        CorrectAnswer = 1,
        Marks = 1,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "In a zigzag fashion"
          },
          new Choice {
            Order = 2,
            Description = "Row by row"
          },
          new Choice {
            Order = 3,
            Description = "Column by column"
          }
        }
      },
      new Question {
        Title = "Q #50: Compressing video means spatially compressing each frame and temporally compressing a set of frames",
        CorrectAnswer = 1,
        Marks = 4,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #51: Spatial compression in MPEG is done with JPEG (or a modification of it)",
        CorrectAnswer = 1,
        Marks = 8,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #52: Spatial compression in MPEG is done with PNG",
        CorrectAnswer = 1,
        Marks = 8,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #53: The 3 categories that MPEG divides its frames into are",
        CorrectAnswer = 1,
        Marks = 1,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "I-frames, P-frames, and B-frames"
          },
          new Choice {
            Order = 2,
            Description = "A-frames, B-frames, and C-frames"
          },
          new Choice {
            Order = 3,
            Description = "B-frames, P-frames, and R-frames"
          },
          new Choice {
            Order = 4,
            Description = "T-frames, I-frames, and B-frames"
          }
        }
      },
      new Question {
        Title = "Q #54: ___________ is an independent frame that is not related to any other frame",
        CorrectAnswer = 1,
        Marks = 1,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "I-frames"
          },
          new Choice {
            Order = 2,
            Description = "P-frames"
          },
          new Choice {
            Order = 3,
            Description = "B-frames"
          }
        }
      },
      new Question {
        Title = "Q #55: ___________ is predicted frame that is related to the preceding frame",
        CorrectAnswer = 1,
        Marks = 2,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "I-frames"
          },
          new Choice {
            Order = 2,
            Description = "P-frames"
          },
          new Choice {
            Order = 3,
            Description = "B-frames"
          }
        }
      },
      new Question {
        Title = "Q #56: ___________ is a bidirectional frame that is related to the preceding and following frame",
        CorrectAnswer = 1,
        Marks = 7,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "I-frames"
          },
          new Choice {
            Order = 2,
            Description = "P-frames"
          },
          new Choice {
            Order = 3,
            Description = "B-frames"
          }
        }
      },
      new Question {
        Title = "Q #57: A B-frame can be related to another B-frame",
        CorrectAnswer = 1,
        Marks = 7,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #58: A P-frame can be related to an I-frame",
        CorrectAnswer = 1,
        Marks = 1,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #59: When using only a web server to download an audio/video file, the file can be played before the downloading has finished",
        CorrectAnswer = 1,
        Marks = 1,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #60: When using a web server with a metafile to download an audio/video file, the media player is directly connected to the Web server for downloading the file",
        CorrectAnswer = 1,
        Marks = 6,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #61: When using a web server with a metafile to download an audio/video file, the Web server only stores the actual audio/video file",
        CorrectAnswer = 1,
        Marks = 6,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #62: A problem when using a web server with a metafile to download an audio/video file is that the browser and  media player both use HTTP. ",
        CorrectAnswer = 1,
        Marks = 2,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #63: When using a web server with a media server to download an audio/video file, the media player uses the URL in the metafile to access the media server to download the file",
        CorrectAnswer = 1,
        Marks = 2,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #64: The protocol used to download a file from a web server to your browser should utilize TCP, in case a damaged file needs to be retransmitted",
        CorrectAnswer = 1,
        Marks = 4,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #65: Real-Time Streaming Protocol is an in-band control protocol",
        CorrectAnswer = 1,
        Marks = 8,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #66: Real-Time Streaming Protocol is an out-of-band control protocol",
        CorrectAnswer = 1,
        Marks = 3,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #67: Real-Time Streaming Protocol is used to",
        CorrectAnswer = 1,
        Marks = 4,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "Control the playing of audio/video"
          },
          new Choice {
            Order = 2,
            Description = "Display the video in a video player"
          },
          new Choice {
            Order = 3,
            Description = "Compress the video so that it can be efficiently downloaded from a web server"
          },
          new Choice {
            Order = 4,
            Description = "Allow users to interact with another user through the Internet"
          }
        }
      },
      new Question {
        Title = "Q #68: Real-Time Streaming Protocol defines a compression scheme for audio and video",
        CorrectAnswer = 1,
        Marks = 2,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #69: Real-Time Streaming Protocol does not define how audio and video are encapsulated in packets for transmission over a network",
        CorrectAnswer = 1,
        Marks = 3,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #70: Real-Time Streaming Protocol can only be transported using UDP",
        CorrectAnswer = 1,
        Marks = 4,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #71: Real-Time Streaming Protocol does not restrict how the media player buffers the audio/video",
        CorrectAnswer = 1,
        Marks = 4,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #72: The media stream used when streaming a video from a web server is considered in-band",
        CorrectAnswer = 1,
        Marks = 5,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #73: Streaming ________ audio/video is multicast",
        CorrectAnswer = 1,
        Marks = 7,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "Stored"
          },
          new Choice {
            Order = 2,
            Description = "Live"
          }
        }
      },
      new Question {
        Title = "Q #74: Streaming ________ audio/video is unicast",
        CorrectAnswer = 1,
        Marks = 9,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "Stored"
          },
          new Choice {
            Order = 2,
            Description = "Live"
          }
        }
      },
      new Question {
        Title = "Q #75: When using real-time interactive audio/video, the time relationship between the packets is preserved",
        CorrectAnswer = 1,
        Marks = 3,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #76: Jitter is the variation of packet delay",
        CorrectAnswer = 1,
        Marks = 3,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #77: Real-time traffic in interactive audio/video does not require a playback buffer",
        CorrectAnswer = 1,
        Marks = 8,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "True"
          },
          new Choice {
            Order = 2,
            Description = "False"
          }
        }
      },
      new Question {
        Title = "Q #78: Client-side _______________________ compensate for delay jitter",
        CorrectAnswer = 1,
        Marks = 9,
        Choices = new List < Choice > {
          new Choice {
            Order = 1,
            Description = "Buffering"
          }
        }
      }
        };
        private static List<Question> AllShuffled => All.OrderBy(x => random.Next()).ToList();
    }
}

