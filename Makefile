
build:
	docker build -t bernardolm/meuponto-api-csharp .

run: build
	# docker run -p 4321:4321 -t bernardolm/meuponto-api-csharp
	docker run -t bernardolm/meuponto-api-csharp /bin/sh -c "scriptcs -install ScriptCs.WebApi; scriptcs -install; scriptcs server.csx"
