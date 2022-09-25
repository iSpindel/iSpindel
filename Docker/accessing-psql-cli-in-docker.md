 # Accessing the database in the container
 docker run -it --rm --network ispindel postgres psql -h <container-name> -U <user> -d <database>
 docker run -it --rm --network ispindel postgres psql -h database -U ispindel -d iSpindel