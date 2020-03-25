# Read from the file file.txt and output the tenth line to stdout.
i=0
while IFS= read -r line
do
  i=$((i+1))
  if [[ "$i" -eq 10 ]]; then
    echo "$line"
  fi
done < file.txt
