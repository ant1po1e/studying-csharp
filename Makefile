compile:
	@./cmd/compile.sh

run:
	@./cmd/run.sh

dev:
	@mcs -out:./helloWorld.exe ./helloWorld.cs

rund:
	@mono helloWorld.exe

.PHONY: compile run