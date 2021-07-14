
# Instructions
- You will need Visual Studio to complete challenges outlined below. We suggest you utilize one of the community editions provided at https://www.visualstudio.com/downloads/
- Clone this repo to your local machine
- Use it to create a new repo on GitHub under your own account (please don't use GitHub fork to accomplish this)
- Complete the challenge below or provide an alternative representative sample of code or classes that is solely your work product. 
  (If you maintain a github project where you are the sole contributor, please feel free to submit a link and description of what we should review in the repository.)
- Send us an email with a link to your repo and any instructions or details you want to share about key features, performance optimizations or creative problem solving skills that they exemplify.

## Also Energy Code Challenge

### Please review the projects in the Challenge solution and perform the following tasks. Please feel free to be creative and simplify when possible. 

1) Fix the bug causing the existing unit test to fail.

2) Add a PermissionSet class to hold a fixed list of 100 user permissions (i.e. perm1, perm2, ...). 
   The PermissionSet should be able to serialize/deserialize as a byte array.

3) Provide a brief comment for each of the following:

   - Concept or element that was unfamiliar or unexpected

      - SQL project threw mew off at first. Haven't used one in quite a long time and mainly used it for schema.
      - All the manual binary serialization code was unexpected. This is the first time I have seen anyone leverage SQL CLR to run c# on SQL Server in practice.

   - Constructive review or recommended improvement

      - I like that the challenge had you track down a bug and fix it.
      - I appreciate the transparency in using code from your actual system!
      - Would be great to explain a bit more how this library is called from application layer to give a bit more context

   - Opportunity or future enhancement

      - Adding docker support and a way to leverage this in SQL so that you can see it in action would be really cool!

      