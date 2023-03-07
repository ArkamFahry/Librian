package utils

import (
	"strings"
	"time"
)

func StringToStringSlice(s string) []string {
	return strings.Split(s, ",")
}

func StringSliceContains(s []string, e string) bool {
	for _, a := range s {
		if a == e {
			return true
		}
	}
	return false
}

func RemoveDuplicateString(strSlice []string) []string {
	allKeys := make(map[string]bool)
	var list []string
	for _, item := range strSlice {
		if _, value := allKeys[item]; !value {
			allKeys[item] = true
			list = append(list, item)
		}
	}
	return list
}

func RemoveElementInSliceByValue(strSlice []string, str string) []string {
	var slice []string
	for _, value := range strSlice {
		if value != str {
			slice = append(slice, value)
		}
	}

	return slice
}

func DifferenceBetweenTwoStringSlices(strSlice1 []string, strSlice2 []string) []string {
	var diff []string

	// Loop two times, first to find slice1 strings not in slice2,
	// second loop to find slice2 strings not in slice1
	for i := 0; i < 2; i++ {
		for _, s1 := range strSlice1 {
			found := false
			for _, s2 := range strSlice2 {
				if s1 == s2 {
					found = true
					break
				}
			}
			// String not found. We add it to return slice
			if !found {
				diff = append(diff, s1)
			}
		}
		// Swap the slices, only if it was the first loop
		if i == 0 {
			strSlice1, strSlice2 = strSlice2, strSlice1
		}
	}

	return diff
}

func DurationUint64(duration time.Duration) uint64 {
	seconds := duration.Seconds()

	return uint64(seconds)
}
