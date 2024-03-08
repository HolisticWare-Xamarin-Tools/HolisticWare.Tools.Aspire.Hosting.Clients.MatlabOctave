


https://www.mathworks.com/help/matlab/ref/run.html

https://arc.umich.edu/software/matlab/#:~:text=To%20run%20a%20MATLAB%20script,m%20from%20the%20current%20directory.&text=Note%20that%20the%20MATLAB%20script,an%20exit%20command%20in%20it.

runs the Matlab script my_simulation.m from the current directory.

matlab -r ./my_simulation

If your program does not contain an exit, you can supply it on the command line with

matlab -nodisplay -r "./my_simulation ; exit"


If your my_simulation.m script can be invoked with arguments, say the number of iterations and mesh size as the two arguments, you can also pass those on the command line with

matlab -nodisplay -r "./my_simulation(2, 10)"


"C:\<a long path here>\matlab.exe" -nodisplay -nosplash -nodesktop -r "run('C:\<a long path here>\mfile.m'); exit;"

https://stackoverflow.com/questions/6657005/matlab-running-an-m-file-from-command-line