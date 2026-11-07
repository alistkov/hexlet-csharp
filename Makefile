install:
	dotnet restore src/App
	dotnet restore tests/App.Tests

setup: install
	dotnet publish src/App -c Release -o dist

build:
	dotnet build

clean:
	dotnet clean
	rm -rf dist

run:
	dotnet run --project src/App

run-dist:
	./dist/App

update-deps:
	dotnet-outdated

build-run: build run

.PHONY: build test
