
read -p "Directory: " dir

mcs -out:./$dir/Program.exe ./$dir/Program.cs
